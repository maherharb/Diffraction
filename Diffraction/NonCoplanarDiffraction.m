% NONCOPLANARDIFFRACTION Calculate the incident and reflected vectors for
% difraction from lattice planes in a non-coplanar geometry; and (optional)
% Draw the geometry in 3D.
%
% RESULT = NONCOPLANARDIFFRACTION(BRAGGANGLE, GRAZINGANGLE, SURFACENORMAL, REFLECTIONNORMAL, FIGNUM)
%             BRAGGANGLE: Bragg angle in deg. for the reflection of interest
%           GRAZINGANGLE: Angle of incidence relative to surface in deg.
%          SURFACENORMAL: Vector defining the surface normal of the crystal in cartesian coordinates
%       REFLECTIONNORMAL: Vector defining the normal of the reflection planes in cartesian coordinates
%                 FIGNUM: (optional) Figure number in which to draw the diffraction geometry
%                 RESULT: a structure data-type containing:
%                       .TransformedSurfaceNormal: z-axis       
%                       .TransformedReflectionNordmal: Such that x-axis is the intersection between reflection planes and surface         
%                       .Incident: Incident beam in cartesian coordinates
%                       .IncidentSpherical: Incident beam in spherical coordinates
%                       .Reflected: Reflected beam in cartesian coordinates
%                       .ReflectedSpherical: Reflected beam in spherical coordinates
%
% Note that a non-coplanar geometry can be realized only if the angle of
% assymetry (between reflection planes and surface) is larger than the
% Bragg Angle. NONCOPLANARDIFFRACTION applies a series of tranformations to
% align the surface normal with the z-axis and the intersection between the
% reflection planes and the surface with the x-axis. Hint: for non-cubic
% crytals, call the StructureFactor function to compute SURFACENORMAL and
% REFLECTIONNORMAL in cartesian coordinates (see example 2 below).
%
% Example 1 (cubic lattice):
%   NonCoplanarDiffraction(10, 0.5, [0 0 1], [1 1 1], 1)
%
% Exampe 2 (hexagonal lattice):
%   load graphite.mat
%   Lattice.Normal = [0 0 1];
%   Lattice.Reflection = [1 0 2];
%   Probe.Type = 'xrays';
%   Probe.Energy = 15000;
%   Probe.DiffractionGeometry = 'noncoplanar';
%   Probe.psi = 0.5;
%   SF = StructureFactor(Lattice, Probe);
%   NonCoplanarDiffraction(SF.BraggAngle, Probe.psi, SF.CrystalNormal, SF.ReflectionNormal, 1)
%
% Last update: 05-03-2011, Maher Harb
% Last update: 05-15-2017, Jacob Bolduc




function Result = NonCoplanarDiffraction(BraggAngle, GrazingAngle, SurfaceNormal, ReflectionNormal, FigNum)


% Check angle of assymetry
AssymAngle = acosd((ReflectionNormal*SurfaceNormal')/(sqrt(sum(ReflectionNormal.^2))*sqrt(sum(SurfaceNormal.^2))));
if BraggAngle>AssymAngle
    warning('Non-coplanar diffraction not possible with Bragg angle > Assymetry angle')
end


% Convert angles to rad.
IncidentPsi = (GrazingAngle+90)*pi/180; % use conventional spherical coordinate (psi=0 for z-axis)
BraggAngle = BraggAngle*pi/180;


% Normalize surface and reflection vectors
SurfaceNormal = SurfaceNormal/sqrt(SurfaceNormal*SurfaceNormal');
ReflectionNormal = ReflectionNormal/sqrt(ReflectionNormal*ReflectionNormal');


% Rotate crystal such that surface normal points to z-axis
if SurfaceNormal(2) ~=0
    ay = pi/2 - acos(([0 1 0]*(SurfaceNormal.*[0 1 1])')/sqrt(sum((SurfaceNormal.*[0 1 1]).*(SurfaceNormal.*[0 1 1]))));
    TransMat = [1 0 0; 0 cos(-ay) -sin(-ay); 0 sin(-ay) cos(-ay)];
    SurfaceNormal = SurfaceNormal*TransMat;
    ReflectionNormal = ReflectionNormal*TransMat;
    %  ax*180/pi
end
if SurfaceNormal(1) ~=0
    ax = pi/2 - acos(([1 0 0]*SurfaceNormal')/sqrt(sum(SurfaceNormal.*SurfaceNormal)));
    TransMat = [cos(ax) 0 sin(ax); 0 1 0; -sin(ax) 0 cos(ax)];
    SurfaceNormal = SurfaceNormal*TransMat;
    ReflectionNormal = ReflectionNormal*TransMat;
    %  ay*180/pi
end
Result.TransformedSurfaceNormal = SurfaceNormal;


% Rotate crystal such that reflection planes aligned with x-axis
theta0 = atan(ReflectionNormal(2)/ReflectionNormal(1));
if ReflectionNormal(1)<0 && ReflectionNormal(2)>0 
    theta0 = pi/2+theta0;
end
if ReflectionNormal(1)<0 && ReflectionNormal(2)<0 
    theta0 = pi+theta0;
end
if ReflectionNormal(1)>0 && ReflectionNormal(2)<0 
    theta0 = 2*pi+theta0;
end

%if imag(theta0)==0
%theta0*180/pi
%end

theta0 = pi/2-theta0;

TransMat = [cos(theta0) -sin(theta0); sin(theta0) cos(theta0)];
% TransMat = [cos(pi/2-theta0) -sin(pi/2-theta0); sin(pi/2-theta0) cos(pi/2-theta0)];
ReflectionNormal(1,1:2) = (TransMat*(ReflectionNormal(1,1:2)'))';

% normalize
ReflectionNormal = ReflectionNormal/sqrt(ReflectionNormal*ReflectionNormal');

%phi_plane = atan(ReflectionNormal(2)/ReflectionNormal(1))*180/pi;
%theta_plane = acos(ReflectionNormal(3)/sqrt(ReflectionNormal*ReflectionNormal'))*180/pi;

theta = asin((cos(pi/2+BraggAngle)-ReflectionNormal(3)*cos(IncidentPsi))/(ReflectionNormal(2)*sin(IncidentPsi)));

Incident = [sin(IncidentPsi)*cos(theta), sin(IncidentPsi)*sin(theta), cos(IncidentPsi)];
Incident = Incident/sqrt(Incident*Incident');

Reflected = Incident - 2*ReflectionNormal*(Incident*ReflectionNormal');
Reflected = Reflected/sqrt(Reflected*Reflected');


%Calculate reflected angles
theta_r = atan(Reflected(2)/Reflected(1));
if Reflected(1)<0
    theta_r = theta_r +pi;
end
theta_r = theta_r*180/pi;
psi_r = acos(Reflected(3)/sqrt(Reflected*Reflected'));
psi_r = psi_r*180/pi;


%Calculate incident angles
theta_i = atan(Incident(2)/Incident(1));
if Incident(1)<0
    theta_i = theta_i +pi;
end
% theta_i = theta;
theta_i = theta_i*180/pi;
psi_i = acos(Incident(3)/sqrt(Incident*Incident'));
psi_i = psi_i*180/pi;


%Write properties to Result
Result.TransformedReflectionNormal = ReflectionNormal;
Result.Incident = Incident;
Result.IncidentSpherical = [theta_i psi_i];
Result.Reflected = Reflected;
Result.ReflectedSpherical = [theta_r psi_r];


if nargin>4 % plot result
    figure(FigNum)
    hold off
    arrow3D([0,0,0], Result.TransformedReflectionNormal*100,  'k', 0.90);
    hold on
    if(Result.TransformedReflectionNormal(3)==0)
        p1=cross(Result.TransformedReflectionNormal,[Result.TransformedReflectionNormal(1)+0.5;Result.TransformedReflectionNormal(2)-0.33;Result.TransformedReflectionNormal(3)]);
        p2=cross(Result.TransformedReflectionNormal,[Result.TransformedReflectionNormal(1)+0.35;Result.TransformedReflectionNormal(2)-0.98;Result.TransformedReflectionNormal(3)+1]);
        % The values used here do not represent anything. For better ratio of
        % the planes, adjust them in the two lines above.
    else
        p1=[0, Result.TransformedReflectionNormal(3), -Result.TransformedReflectionNormal(2)] ;
        p2=[Result.TransformedReflectionNormal(3), 0, -Result.TransformedReflectionNormal(1)] ;
    end
    plotp(p1',p2')
    arrow3D([0,0,0], Result.Reflected*100,  'r', 0.90);
    arrow3D(-Result.Incident*100, Result.Incident*100,   'r', 0.90);
    title(strcat(['Azimuthal deviation = ', num2str(Result.IncidentSpherical(1)-Result.ReflectedSpherical(1),2), ' deg ; Exit angle relative to surface = ', num2str(90-Result.ReflectedSpherical(2),2), ' deg']))
end


% Result.IncidentSpherical