% STRUCTUREFACTOR Calculate the structure factor and other diffraction properties.
%
% STRUCTUREFACTOR(LATTICE) Calculate the structure factor assuming all atomic scattering factors = 1
%             LATTICE is a structure data-type containing:
%             .Symbol: Chemical symbol of the molecule
%               .Type: 'cubic', 'tetragonal', 'orthorhombic', 'hexagonal', 'rhombohedral', 'monoclinic', 'triclinic'
%            .a .b .c: lattice constants in Angstroms (depending on lattice type some of these are not needed)
% .alpha .beta .gamma: lattice constants in degrees (depending on lattice type some of these are not needed)
%   .CoordinateSystem: (optional) 1 (default) for lattice coordinate system, 0 for cartesian coordinate system
%    .AtomicPositions: n by 3  matrix, each row represents atomic coordinates
%        .AtomicTypes: (optional) 1xn vector defining the type of the atom for each row of the AtomicPositions Matrix
%         .Reflection: 1x3 vector containing the Miller indices of the reflection of interest
%             .Normal: 1x3 vector defining the direction of the surface normal of the crystal
%
% STRUCTUREFACTOR(LATTICE, PROBE) Calculate the structure factor using the proper values for the atomic scattering factors
%             PROBE is a structure data-type containing:
%              .Type: (optional) 'xrays' (default), 'electrons'
%            .Energy: Energy of the probe in eV
%
% Example 1 (minimum required input):
%   Lattice.Symbol = 'Au';
%   Lattice.Type = 'cubic';
%   Lattice.a = 4.08;
%   Lattice.AtomicPositions = [0 0 0; 0.5 0.5 0; 0.5 0 0.5; 0 0.5 0.5];
%   Lattice.Reflection = [1 1 1];
%   StructureFactor(Lattice)
%
% Exampe 2 :
%   Lattice.Symbol = 'InSb';
%   Lattice.Type = 'cubic';
%   Lattice.a = 6.479;
%   Lattice.AtomicPositions = [0 0 0; 0.5 0.5 0; 0.5 0 0.5; 0 0.5 0.5; 0.25 0.25 0.25; 0.75 0.75 0.25; 0.75 0.25 0.75; 0.25 0.75 0.75];
%   Lattice.AtomicTypes = [1 1 1 1 2 2 2 2];
%   Lattice.Reflection = [1 1 1];
%   Lattice.Normal = [0 0 1];
%   Probe.Type = 'xrays';
%   Probe.Energy = 10000;
%   StructureFactor(Lattice, Probe)
% 
% Example 3 :
%     Lattice.Symbol='CrAlC';
%     Lattice.Type='hexagonal';
%     Lattice.a=2.8420;
%     Lattice.c=12.6870;
%     Lattice.AtomicPositions = [1/3 2/3 0.0847; 0.3333 0.6667 0.4153; 0.6667 0.3333 0.5847; 0.6667 0.3333 0.9153; 0.6667 0.3333 0.2500; 0.3333 0.6667 0.7500; 0 0 0; 0 0 0.5000];
%     Lattice.Atomic
%     Lattice.Reflection=[1 1 1];
%     Lattice.Z=[24 13 6];
%     Lattice.N=[4 2 2];
%     Lattice.Normal=[0 0 1];
%     Lattice.Vc=8.8744e-29;
%     Probe.Type = 'xrays';
%     Probe.Energy = 10000;
% 
%
% Last update: 04-12-2017, Cosmin Popescu
% Author: Maher Harb 04-11-2011


function [Result, Lattice, Probe] = StructureFactor(Lattice, Probe)

RADIUS_ELECTRON = 2.817940325e-15; % electron radius [m]
SPEED_LIGHT = 299792458; % speed of light [m]
ELEMENTARY_CHARGE = 1.6021766e-19; %
PLANCK = 6.626068e-34; % h [J]
AMU = 1.66053886e-27; % [Kg]
M_E = 9.10938188e-31;

if nargin<1
    error('Not enough input arguments. Type "help StructureFactor" to learn more.');
else
%     check that Lattice is well defined
    if isfield(Lattice,'Symbol')==1
        [Lattice.Z, N] = ParseChemicalSymbol(Lattice.Symbol);
        if length(Lattice.Z)>1 % molecule
            Lattice.N = N;
        end
    else
        error('Lattice.Symbol is not defined. Type "help StructureFactor" to learn more.')
    end
    if isfield(Lattice,'Reflection')==1
        h = Lattice.Reflection(1);
        k = Lattice.Reflection(2);
        l = Lattice.Reflection(3);
    else
        error('Lattice.Reflection is not defined. Type "help StructureFactor" to learn more.')
    end
    if isfield(Lattice,'Normal')==1
        hkl_surf = Lattice.Normal;
    else
        hkl_surf = Lattice.Reflection; % symmetric geometry
    end
end

% check that Probe is well defined
if nargin>1
    if isfield(Probe,'Type')==0 % default is xray
        Probe.Type = 'xrays';
             
    end
    if isfield(Probe,'Energy')==0
        error('Probe.Energy is not defined. Type "help StructureFactor" to learn more.');
    end
end





Lattice = CartesianSystem(Lattice); % calcultes lattice vectors in cartesian system
Result = Lattice;
Result.ReciprocalLatticeVectors = zeros(3,3);
Result.Reflection = [h k l];
NumberOfAtoms = size(Lattice.AtomicPositions, 1);

%% Calculate multiplicity
switch lower(Lattice.Type)
    case 'triclinic'
        % Result.Distance = (h ^ 2 / a ^ 2 * Math.Sin(alpha) ^ 2 + k ^ 2 / b ^ 2 * Math.Sin(beta) ^ 2 + l ^ 2 / c ^ 2 * Math.Sin(gamma) ^ 2 + 2 * h * k * (Math.Cos(alpha) * Math.Cos(beta) - Math.Cos(gamma)) / (a * b) + 2 * l * k * (Math.Cos(gamma) * Math.Cos(beta) - Math.Cos(alpha)) / (c * b) + 2 * h * l * (Math.Cos(alpha) * Math.Cos(gamma) - Math.Cos(beta)) / (a * c)) / (1 - Math.Cos(alpha) ^ 2 - Math.Cos(beta) ^ 2 - Math.Cos(gamma) ^ 2 + 2 * Math.Cos(alpha) * Math.Cos(beta) * Math.Cos(gamma))
        Result.Multiplicity = 2;
        
    case 'tetragonal'
        Result.Distance = ((h^2+k^2)/Lattice.a^2+l^2/Lattice.c^2)^-0.5;
        if (h==0 && k==0)  % possible bug with mutiplicity for negative h,k,l values
            Result.Multiplicity = 2;
        elseif (l==0 && (k==0 || h==0 || (k==h)))
            Result.Multiplicity = 4;
        elseif (l==0 || k==0 || h==0 || (h==k))
            Result.Multiplicity = 8;
        else
            Result.Multiplicity = 16;
        end 
        
    case 'monoclinic' % b=twofold axis
        % ToDo
        beta = Lattice.beta*pi/180;
        Result.Distance = (((h^2/Lattice.a^2+l^2/Lattice.c^2-2*h*l*cos(beta)/(Lattice.a*Lattice.c))/(sin(beta)^2))+k^2/Lattice.b^2)^-0.5;
        if ((h==0 && l==0) || k==0)  % possible bug with mutiplicity for negative h,k,l values
            Result.Multiplicity = 2;
        else
            Result.Multiplicity = 4;
        end
        % Cosmin: Seems fine in monoclinic.
    case 'orthorhombic'
        Result.Distance = (h^2/Lattice.a^2+k^2/Lattice.b^2+l^2/Lattice.c^2)^-0.5;
        if (h==0 && k==0 || k==0 && l==0 || l==0 && h==0)
            Result.Multiplicity=2;
        elseif (h==0 || k==0 || l==0)
            Result.Multiplicity=4;
        else 
            Result.Multiplicity=8;
        end
        % Not sure about this orthorhombic part.
    case 'hexagonal'
        Result.Distance = (4/3*((h^2+h*k+k^2)/Lattice.a^2)+l^2/Lattice.c^2)^-0.5;
        if (h==0 && k==0) % possible bug with mutiplicity for negative h,k,l values
            Result.Multiplicity = 2;
        elseif ((h==0 && l==0) || (k==0 && l==0) || (abs(h)==abs(k) && l==0))
            Result.Multiplicity = 6;
        elseif ((l==0) || (k==0) || (h==0) || (h==k))
            Result.Multiplicity = 12;
        else
            Result.Multiplicity = 24;
        end
        
    case 'rhombohedral'
        a = Lattice.a;
        alpha = Lattice.alpha*pi/180;
        Result.Distance = (((h^2+k^2+l^2)*(sin(alpha))^2+2*(h*k+h*l+k*l)*((cos(alpha))^2-cos(alpha)))/(1+2*cos(alpha)^3-3*cos(alpha)^2))^-0.5*a; %    (((h^2+k^2+l^2)*(sin(alpha))^2+2*(h*k+h*l+k*l)*((cos(alpha))^2-cos(alpha)))/(1-2*cos(alpha)^3+3*cos(alpha)^2)/(a^2))^-0.5;
        if ((h==0 && k==0) ||(h==0 && l==0) || (l==0 && k==0))
            Result.Multiplicity = 6;
        elseif ((abs(h)==abs(k) && l==0) || (abs(h)==abs(l) && k==0) || (abs(l)==abs(k) && h==0))
            Result.Multiplicity = 12;
        elseif (h==0 || k==0 || l==0)
            Result.Multiplicity = 24;
        elseif (abs(h)==abs(k) && abs(k)==abs(l))
            Result.Multiplicity = 8;
        elseif (abs(h)==abs(k) || abs(h)==abs(l) || abs(k)==abs(l))
            Result.Multiplicity = 24;
        else
            Result.Multiplicity = 48;
        end % Needs checked  by third party.
        
    otherwise % cubic
        Result.Distance = ((h^2+k^2+l^2)/Lattice.a^2)^-0.5;
        if ((h==0 && k==0) ||(h==0 && l==0) || (l==0 && k==0))
            Result.Multiplicity = 6;
        elseif ((abs(h)==abs(k) && l==0) || (abs(h)==abs(l) && k==0) || (abs(l)==abs(k) && h==0))
            Result.Multiplicity = 12;
        elseif (h==0 || k==0 || l==0)
            Result.Multiplicity = 24;
        elseif (abs(h)==abs(k) && abs(k)==abs(l))
            Result.Multiplicity = 8;
        elseif (abs(h)==abs(k) || abs(h)==abs(l) || abs(k)==abs(l))
            Result.Multiplicity = 24;
        else
            Result.Multiplicity = 48;
        end
end


%% calculate density if not supplied by user
if isfield(Lattice,'Density')==0
    Lattice.Density = Density(Lattice);
end
Result.LatticeDensity = Lattice.Density;


Result.ScatteringVector = 1/Result.Distance;

%% Bragg Angle and Scattering Factor
if nargin>1 % Probe supplied
    Result.ScatteringFactor = zeros(1, size(Lattice.Z,2));
    if strcmpi(Probe.Type,'xrays')==1 || strcmpi(Probe.Type,'x-rays')==1 || strcmpi(Probe.Type,'xray')==1 || strcmpi(Probe.Type,'x-ray')==1
        Probe.lambda = Energy2Wavelength(Probe.Energy)*1e10; % X-ray Probe.lambda [A]
        [f1, f2] = XrayAnomalousFactors(Lattice.Z, Probe.Energy);
        Result.ScatteringFactor = XrayScatteringFactors(Lattice.Z, Result.ScatteringVector) + f1 + 1i*f2 - Lattice.Z;
        Result.IndexOfRefraction = XrayIndexOfRefraction(Lattice.Symbol, Lattice.Density, Probe.lambda);
        Result.Probe = 'xrays';
        Result.Energy = Probe.Energy;
    else % electrons
        Probe.lambda = Energy2Wavelength(Probe.Energy, M_E)*1e10; % Angstroms
        Result.ScatteringFactor = ElectronRealScatteringFactor(Lattice.Z, Result.ScatteringVector, 'electrons');
    end % Why did he use electrons as third argument in ElectronRealScatteringFactor? It doesn't do anything. It should be a number for a fig number in theory but in this case it does nothing. 
    
    Result.BraggAngle = asin(Probe.lambda/2/Result.Distance)*180/pi;
end


%% Calculate reciprocal lattice vectors

% The next 3 lines are fine. 
Result.ReciprocalLatticeVectors(1,:) = 2*pi*cross(Result.LatticeVectors(2,:),Result.LatticeVectors(3,:))/sum(Result.LatticeVectors(1,:).*cross(Result.LatticeVectors(2,:),Result.LatticeVectors(3,:)));
Result.ReciprocalLatticeVectors(2,:) = 2*pi*cross(Result.LatticeVectors(3,:),Result.LatticeVectors(1,:))/sum(Result.LatticeVectors(1,:).*cross(Result.LatticeVectors(2,:),Result.LatticeVectors(3,:)));
Result.ReciprocalLatticeVectors(3,:) = 2*pi*cross(Result.LatticeVectors(1,:),Result.LatticeVectors(2,:))/sum(Result.LatticeVectors(1,:).*cross(Result.LatticeVectors(2,:),Result.LatticeVectors(3,:)));

CrystalSurfaceVectors = sum(Result.ReciprocalLatticeVectors.*[hkl_surf; hkl_surf; hkl_surf]',1);
ReciprocalLatticeVectorsSum = sum(Result.ReciprocalLatticeVectors.*[Lattice.Reflection; Lattice.Reflection; Lattice.Reflection]',1);
Result.ReflectionNormal = normalize(ReciprocalLatticeVectorsSum); %/sqrt(ReciprocalLatticeVectorsSum*ReciprocalLatticeVectorsSum');
Result.CrystalNormal = normalize(CrystalSurfaceVectors); %/sqrt(CrystalSurfaceVectors*CrystalSurfaceVectors');


%% Calculate assymetry angle
Result.AssymAngle = acosd((ReciprocalLatticeVectorsSum*CrystalSurfaceVectors')/(sqrt(sum(CrystalSurfaceVectors.^2))*sqrt(sum(ReciprocalLatticeVectorsSum.^2))));
% Result.AssymAngle = Result.AssymAngle*180/pi; % [degrees]



%% Attenuation Length
if nargin>1
    Result.AttenuationLength = 0;
    if strcmpi(Probe.Type,'xrays')==1 || strcmpi(Probe.Type,'x-rays')==1 || strcmpi(Probe.Type,'xray')==1 || strcmpi(Probe.Type,'x-ray')==1
        GrazingAngle = Result.BraggAngle-Result.AssymAngle;
        if isfield(Probe,'DiffractionGeometry')==1
            if (strcmpi(Probe.DiffractionGeometry,'noncoplanar')==1)
                GrazingAngle = Probe.psi;
            end
        end
        % Result.AttenuationLength = XrayAttenuationLength(GrazingAngle, Result.IndexOfRefraction(1), Result.IndexOfRefraction(2), Probe.lambda)*1e6 ; % based on linear and evanescent absorption
        Result.AttenuationLength = XrayAttenuationLength(Lattice.Symbol, Lattice.Density, Probe.lambda, GrazingAngle) ;
    end
end


%% Calculate geometrical factor
Result.StructureFactor = 0 ;
Result.Intensity = 0 ;
if nargin==1
    f = 1;
else
    f = Result.ScatteringFactor;
end
for n=1:NumberOfAtoms
    if size(Lattice.Z,2)>1
        f = Result.ScatteringFactor(Lattice.AtomicTypes(n));
    end
    Result.StructureFactor = Result.StructureFactor + f*exp(1i*sum(Lattice.AtomicPositionsCartesian(n,:).*ReciprocalLatticeVectorsSum));
    % sum(Lattice.AtomicPositionsCartesian(n,:).*ReciprocalLatticeVectorsSum)
end
%% Calculate Intensity
Result.Intensity = abs(Result.StructureFactor)^2*(1+cosd(2*Result.BraggAngle).^2)/(sind(Result.BraggAngle).^2*cosd(Result.BraggAngle));
