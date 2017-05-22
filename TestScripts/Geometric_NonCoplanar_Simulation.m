% Geometric simulation of x-ray diffraction on a surface.

home;
%close all;

addpath(genpath('C:\Users\Cosmin\Desktop\Grand Diffraction Master'))

% addpath(genpath('C:\Users\Cosmin\Desktop\Diffraction-master\StructureLibrary'))
% addpath(genpath('C:\Users\Cosmin\Desktop\Diffraction-master\TestScripts'))

% Sample
load NaCl.mat

% Lattice normal of the surface
Lattice.Normal = [0 0 1];

% Probe    
Probe.Type = 'x-ray';
% Probe.Energy =12000 ; % [eV]
Probe.Energy=8048.3; %eV  = 1.5405 A
Probe.DiffractionGeometry = 'noncoplanar';
Probe.psi = 0.23; % This is the grazing angle

% Detector
Detector.Shape = 'circle';
Detector.Size = 102; % diameter or length in mm
Detector.SpotFWHMx = 3; % Diffraction spot size on detector
Detector.SpotFWHMy = 3;
Detector.DistanceToSample = 50; % Sample-detector distance in mm
Detector.Offset = [0 40]; % offset from center of beam in mm

% Miller indeces to loop over
hkl=0:9;

% Table=GeometricSimulationNonCop(Lattice,Probe,Detector, hkl);
I = GeometricalSimulation1(Lattice, Probe, Detector, hkl, 1);

