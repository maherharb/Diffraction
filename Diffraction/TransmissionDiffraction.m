

function Result = TransmissionDiffraction(BraggAngle, SurfaceNormal, ReflectionNormal, FigNumElectroRepresentation)

% Convert angles to rad.
IncidentPsi = BraggAngle; % use conventional sphereical coordinate (psi=0 for z-axis)
if isreal(BraggAngle)~=1
    warning('The Bragg angle is a complex value and will not be computed accurately by the program. Complex Bragg angle means that the Bragg law is not satisfied and no reflection is observed from the sample'); 
end

if SurfaceNormal==ReflectionNormal
   warning('The surface and reflection plane normals are equal. The generated plane will have a varied ratio when displayed.'); 
end

BraggAngle = BraggAngle*pi/180;
% Normalize surface and reflection vectors
SurfaceNormal = SurfaceNormal/sqrt(SurfaceNormal*SurfaceNormal');
ReflectionNormal = ReflectionNormal/sqrt(ReflectionNormal*ReflectionNormal');
IncidencePlane =  cross(SurfaceNormal,ReflectionNormal); % normal should be rotated in this plane


% Rotate crystal such that reflection planes aligned with x-axis
theta0 = pi/2 -  BraggAngle;

ux = IncidencePlane(1);
uy = IncidencePlane(2);
uz = IncidencePlane(3);
TransMat = [cos(theta0) + ux^2*(1-cos(theta0)), ux*uy*(1-cos(theta0))-uz*sin(theta0),  ux*uz*(1-cos(theta0))+uy*sin(theta0);...
            ux*uy*(1-cos(theta0))+uz*sin(theta0), cos(theta0) + uy^2*(1-cos(theta0)),  uz*uy*(1-cos(theta0))-ux*sin(theta0);...
            ux*uz*(1-cos(theta0))-uy*sin(theta0), uz*uy*(1-cos(theta0))+ux*sin(theta0), cos(theta0) + uz^2*(1-cos(theta0))];
    

Incident = (TransMat*ReflectionNormal')';
Incident = Incident/sqrt(Incident*Incident');

% Incident = normalize(Incident);
% Incident*ReflectionNormal'
% ReflectionNormal
Reflected = Incident - 2*ReflectionNormal*(Incident*ReflectionNormal');

% reflected
theta_r = atan(Reflected(2)/Reflected(1));
if Reflected(1)<0
    theta_r = theta_r +pi;
end
theta_r = theta_r*180/pi;
psi_r = acos(Reflected(3)/sqrt(Reflected*Reflected'));
psi_r = psi_r*180/pi;

% incident
theta_i = atan(Incident(2)/Incident(1));
if Incident(1)<0
    theta_i = theta_i +pi;
end
theta_i = theta_i*180/pi;
psi_i = acos(Incident(3)/sqrt(Incident*Incident'));
psi_i = psi_i*180/pi;


Result.TransformedReflectionNormal = ReflectionNormal;
Result.Incident = Incident;
Result.IncidentSpherical = [theta_i, psi_i];
Result.Reflected = Reflected;
Result.ReflectedSpherical = [theta_r, psi_r];

if nargin>3 % plot result Needs debugged. If there are FigNum and FigureElectro
    % are equal then it puts them one on top of the other.
    
    figure(FigNumElectroRepresentation)
    hold off
    arrow3D([0,0,0], Result.TransformedReflectionNormal*100,  'k', 0.90);
    hold on
    % This is just so you see a plane of reflection
    if(Result.TransformedReflectionNormal(3)==0)
        p1=cross(Result.TransformedReflectionNormal,[Result.TransformedReflectionNormal(1)+0.5;Result.TransformedReflectionNormal(2)-0.33;Result.TransformedReflectionNormal(3)]);
        p2=cross(Result.TransformedReflectionNormal,[Result.TransformedReflectionNormal(1)+0.35;Result.TransformedReflectionNormal(2)-0.98;Result.TransformedReflectionNormal(3)+1]);
        % The values used here do not represent anything. For better ratio of
        % the planes, adjust them in the two lines above.
    else
        p1=[0, Result.TransformedReflectionNormal(3), -Result.TransformedReflectionNormal(2)] ;
        p2=[Result.TransformedReflectionNormal(3), 0, -Result.TransformedReflectionNormal(1)] ;
    end
    % Plot the plane fo reflection
    plotp(p1',p2','g')
    % Plot the reflected beam arrow.
    arrow3D([0,0,0], Result.Reflected*100,  'r', 0.90);
    % Plot the incident beam arrow.
    arrow3D(-Result.Incident*100, Result.Incident*100,   'r', 0.90);
    title(strcat(['Azimuthal deviation = ', num2str(Result.IncidentSpherical(1)-Result.ReflectedSpherical(1),2), ' deg ; Exit angle relative to surface = ', num2str(90-Result.ReflectedSpherical(2),2), ' deg']))
    
end
% Result.IncidentSpherical


