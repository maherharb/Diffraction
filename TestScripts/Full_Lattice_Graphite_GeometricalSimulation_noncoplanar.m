% EXAMPLE SCRIPT TO GENERATE DIFFRACTION PATTERN FROM NONCOPLANAR DIFFRACTION GEOMETRY

% CLEAN WORKSPACE
home
clear
close all

% PATH TO DIFFWIZ LIBRARY
addpath(genpath('C:\Users\maher\Google drive\DIFFWIZ\'))
addpath(genpath('C:\Users\Cosmin\Desktop\Grand Diffraction Master\'))

% DEFINE LATTICE OR LOAD LATTICE FROM EXISTING STRUCTURE LIBRARY

load graphite.mat

% DEFINE DIRECTION OF CRYSTAL NORMAL
%Lattice.Normal = [0 0 1];
count=1;
for x=0:2
    for y=0:2
        for z=0:2
            
            Lattice.Normal = [x y z];
            % DEFINE X-RAYS
            Probe.Type = 'xrays';
            Probe.Energy = 15000; % [eV]
            Probe.DiffractionGeometry = 'noncoplanar';
            Probe.psi = 0.23; % This's the grazing angle
            
            % DEFINE DETECTOR
            Detector.Shape = 'circle';
            Detector.Size = 102; % diameter or length in mm
            Detector.SpotFWHMx = 3; % Diffraction spot size on detector
            Detector.SpotFWHMy = 3;
            Detector.DistanceToSample = 50; % Sample-detector distance in mm
            Detector.Offset = [0 40]; % offset from center of beam in mm
            
            % MILLER INDICES TO LOOP OVER
            hkl = 0:10;
            
            % MAIN FUNCTION
            I = GeometricalSimulation1(Lattice, Probe, Detector, hkl, count);
            count=count+1;
        end
    end
end


