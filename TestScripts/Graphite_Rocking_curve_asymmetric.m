% diffraction geometry of the (102) peak (noncoplanar)
clear
home
close all

% DEFINE YOUR LATTICE OR LOAD LATTICE FROM EXISTING STRUCTURE LIBRARY
load graphite.mat

% DEFINE YOUR CRYSTAL
Lattice.Normal = [0 0 1]; % direction of crystal surface
Lattice.Reflection = [1 0 4]; % probed planes
Lattice.Thickness = 30e-6;

% DEFINE YOUR X-RAYS
Probe.Type = 'x-ray';
Probe.Energy = 7000; % [eV] % define either Energy or lambda
Probe.Polarization = 's'; % s (perpendicular) or p (parallel)

% CALCULATE THE STRUCTURE FACTOR
SFx = StructureFactor(Lattice, Probe);
Lattice.Reflection = [0 0 0];
SF0 = StructureFactor(Lattice, Probe); % 0 scattering angle

I = XrayRockingCurve(SFx, SF0, Lattice, Probe, 0.004, 100, 1);

hold on
Data = load('Sergey_Graphite_r104_n001_7keV_s.txt', '-ASCII');
plot(Data(:,1)-SFx.BraggAngle+SFx.AssymAngle, Data(:,2), 'r')
%axis([-0.002 0.005 ylim])

