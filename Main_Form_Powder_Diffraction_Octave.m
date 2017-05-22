
% EXAMPLE SCRIPT TO GENERATE DIFFRACTION PATTERN FROM NONCOPLANAR DIFFRACTION GEOMETRY

% CLEAN WORKSPACE
home
clear
close all

% PATH TO DIFFWIZ LIBRARY
% Use add path to connect all files in the subfolders to the directory
addpath(genpath('C:\Users\maher\Google drive\DIFFWIZ\'))
addpath(genpath('C:\Users\Cosmin\Desktop\DiffractionTest_V5\'))

% DEFINE LATTICE OR LOAD LATTICE FROM EXISTING STRUCTURE LIBRARY
load graphite.mat

% DEFINE DIRECTION OF CRYSTAL NORMAL
Lattice.Normal = [0 0 1]; 

% DEFINE X-RAYS
Probe.Type = 'xrays';
Probe.Energy = 8048.3; % [eV]

% DEFINE DETECTOR
% Detector is not used for Powder Diffraction.

% MILLER INDICES TO LOOP OVER 
hkl = 6;

%Ignores all peaks which have intensities under 1.
Threshold = 1;

%Resolution between peaks.
Separation = 0.1;


% MAIN FUNCTION
% I = Generate_Intensity_2theta(Lattice, Probe,1,hkl,Threshold, Separation)

% For Ocatave Use
I = Generate_Intensity_2theta_Octave(Lattice, Probe,1,hkl,Threshold, Separation)
