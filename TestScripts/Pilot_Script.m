%% Pilot script
home;
close all;

addpath(genpath('C:\Users\Cosmin\Desktop\Diffraction-master\StructureLibrary'))
addpath(genpath('C:\Users\Cosmin\Desktop\Diffraction-master\TestScripts'))


load graphite.mat
    
Probe.Type = 'xray';
Probe.Energy = 8048.3; % [eV]
Probe.DiffractionGeometry = 'noncoplanar';
Probe.psi = 0.1; % This is the grazing angle

% Lattice.Reflection=[1 2 0];
% Lattice.Normal = [0 0 1];

Detector.Shape = 'circle';
Detector.Size = 15; % diameter or length in mm
Detector.SpotFWHMx = 0.3; % Diffraction spot size on detector
Detector.SpotFWHMy = 0.3;
Detector.DistanceToSample = 200; % Sample-detector distance in mm
Detector.Offset = [0 0]; % offset from center of beam in mm
Threshold=1;
Resolution=0.1;
hkl=6;
% FigNum=1;

[Table]=Generate_Intensity_2theta(Lattice, Probe,Threshold, Resolution, hkl,2) %,FigNum);

% hkl=-6:6;
% [SF,~,~]=StructureFactor(Lattice,Probe);
% % I=GeometricalSimulation2(Lattice, Probe,Detector, hkl,1,[]);
% Result =NonCoplanarDiffraction(SF.BraggAngle,Probe.psi, SF.CrystalNormal, SF.ReflectionNormal, 3)

% IMAGE = CreateSpot(G, 10, 10, 5, 5, 100, 50);

