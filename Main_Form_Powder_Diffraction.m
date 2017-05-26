% EXAMPLE SCRIPT TO GENERATE DIFFRACTION PATTERN FROM NONCOPLANAR DIFFRACTION GEOMETRY
% Last Updated 5/26/17 - Jacob Bolduc

% CLEAN WORKSPACE
home
clear
close all

% PATH TO DIFFWIZ LIBRARY
addpath(genpath('C:\Users\maher\Google drive\DIFFWIZ\'))


% DEFINE LATTICE OR LOAD LATTICE FROM EXISTING STRUCTURE LIBRARY
load graphite
% When making the material file, keep the space group in mind. For
% instance, you might have 5 atoms in your stoichiometry with a 1:1:3
% ration, but because of the space group, the number of atoms and positions
% in the unit cell is dictated by an algorithm specific to the group. That
% is why, if the material requires 4 positions for the same atom in the
% unit cell due to its symmetry type, then from 5 atoms you will end with
% 20 atoms and you will need 20 inputs in Lattice.AtomicPositions and
% Lattice.AtomicTypes. 


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
%Defines width of the peak. Decrease to improve resolution.
Separation = 0.1;


% MAIN FUNCTION
I = Generate_Intensity_2theta(Lattice, Probe,1,hkl,Threshold, Separation)