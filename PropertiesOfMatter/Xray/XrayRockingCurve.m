function I = XrayRockingCurve(SFx, SF0, Lattice, Xrays, ThetaRange, NoSteps, FigNum)

run Constants % fundamental constants


if isfield(Xrays,'Energy')==1
    Xrays.lambda = Energy2Wavelength(Xrays.Energy);
end


% calculate Debye Waller Factor
DWF = 1;
% DWF = exp(-DWFactor(Lattice.Z, Lattice.Temperature)*(SFx.ScatteringVector)^2/2); % Todo: check def of DWF for x-ray equition (intensity vs. amplitude?)


thetaB_rad = SFx.BraggAngle*pi/180;
dtheta = linspace(-ThetaRange/2, + ThetaRange/2, NoSteps)*pi/180; % rad


% calculate polarization factor
if lower(Xrays.Polarization) == 'p'
    kpol = cos(2*thetaB_rad);
else
    kpol = 1;
end

% component of... 
gamma0 = sin((SFx.BraggAngle-SFx.AssymAngle)*pi/180); % ...incident beam along crystal surafce-normal
gammaH = sin((SFx.BraggAngle+SFx.AssymAngle)*pi/180); % ...diffracted beam along crystal surafce-normal

% some parameters for solving the Tagaki equations
b = gammaH/gamma0; % asymmetry parameter = 1 for symmetric reflections
b = 1; % 
g = -(imag(SF0.StructureFactor)*(1+b))/(2*kpol*real(SFx.StructureFactor)*DWF*sqrt(abs(b)));
A = RADIUS_ELECTRON*kpol*real(SFx.StructureFactor)*DWF*Xrays.lambda/(SFx.Vc*sqrt(gamma0*gammaH));
k = imag(SFx.StructureFactor)/real(SFx.StructureFactor); % corrected by Author, taken from Zachariazen. With this value one gets the same RC (rocking curve) as XOP gives!!!!!
y = (b*pi*SFx.Vc*sin(2*thetaB_rad)*dtheta)/(kpol*Xrays.lambda^2*RADIUS_ELECTRON*real(SFx.StructureFactor)*DWF*sqrt(abs(b)));
y = y - ((1+b)*real(SF0.StructureFactor))/(2*kpol*real(SFx.StructureFactor)*DWF*sqrt(abs(b)));

% Rocking curve
I=[]; 
for i=1:size(dtheta,2)
    [t, X] = ode45('Takagi',[A*Lattice.Thickness 0], [0; 0], [], k, g, y(i)); 
    I=[I; dtheta(i)*180/pi (X(length(t),1).^2+X(length(t),2).^2)];
    display(strcat([num2str(i), '/', num2str(NoSteps)]))
end

figure(FigNum)
plot(I(:,1), I(:,2))
xlabel('Offset from Bragg angle [deg]')
ylabel('Intensity')

end

