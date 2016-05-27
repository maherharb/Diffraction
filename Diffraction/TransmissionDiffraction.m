

function Result = TransmissionDiffraction(BraggAngle, SurfaceNormal, ReflectionNormal, FigNum)

% Convert angles to rad.
IncidentPsi = BraggAngle; % use conventional sphereical coordinate (psi=0 for z-axis)
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
Result.IncidentSpherical = [theta_i psi_i];
Result.Reflected = Reflected;
Result.ReflectedSpherical = [theta_r psi_r];

if nargin>3 % plot result
    figure(FigNum)
    hold off
    arrow3D([0,0,0], Result.TransformedReflectionNormal*100,  'k', 0.90);
    hold on
    p1=[0 Result.TransformedReflectionNormal(3) -Result.TransformedReflectionNormal(2)] ;
    p2=[Result.TransformedReflectionNormal(3) 0 -Result.TransformedReflectionNormal(1)] ;
    plotp(p1',p2')
    arrow3D([0,0,0], Result.Reflected*100,  'r', 0.90);
    arrow3D(-Result.Incident*100, Result.Incident*100,   'r', 0.90);
    title(strcat(['Azimuthal deviation = ', num2str(Result.IncidentSpherical(1)-Result.ReflectedSpherical(1),2), ' deg ; Exit angle relative to surface = ', num2str(90-Result.ReflectedSpherical(2),2), ' deg']))
end

% Result.IncidentSpherical