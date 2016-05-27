% diffraction geometry of the (102) peak (noncoplanar)
clear
home
close all

% DEFINE YOUR LATTICE OR LOAD LATTICE FROM EXISTING STRUCTURE LIBRARY
load InSb.mat

% DEFINE YOUR CRYSTAL
Lattice.Normal = [1 1 1]; % direction of crystal surface
Lattice.Reflection = [1 1 1]; % probed planes
Lattice.Thickness = 50e-6;

% DEFINE YOUR X-RAYS
Probe.Type = 'x-ray';
Probe.Energy = 1915; % [eV] % define either Energy or lambda
Probe.Polarization = 's'; % s (perpendicular) or p (parallel)

% CALCULATE THE STRUCTURE FACTOR
SFx = StructureFactor(Lattice, Probe);
Lattice.Reflection = [0 0 0];
SF0 = StructureFactor(Lattice, Probe); % 0 scattering angle

I = XrayRockingCurve(SFx, SF0, Lattice, Probe, 0.4, 100, 1);

hold on
%Data = load('Sergey_Graphite_7keV_s.txt', '-ASCII');
%plot(Data(:,1), Data(:,2), 'r')
axis([xlim ylim])

