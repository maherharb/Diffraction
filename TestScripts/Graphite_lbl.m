% test DIFFWIZ against CXRO for Graphite density = 2.2 g/cm3
close all
home
clear

% PATH TO DIFFWIZ LIBRARY
% addpath(genpath('C:\Users\maher\Documents\My Dropbox\DIFFWIZ\'))
addpath(genpath('D:\Dropbox\Lund\DIFFWIZ\'))

figure(1) % index of refraction
lbl_n = load('Graphite_IndexOfRefraction.txt');
Energy = [1000:100:20000]';
IndexOfRefraction = XrayIndexOfRefraction('C', 2.2, Energy);
subplot(1,2,1)
semilogy(Energy, IndexOfRefraction(:,1), 'or')
hold on
semilogy(lbl_n(:,1), lbl_n(:,2))
xlabel('energy [eV]')
ylabel('delta')
box on
subplot(1,2,2)
semilogy(Energy, IndexOfRefraction(:,2), 'or')
hold on
semilogy(lbl_n(:,1), lbl_n(:,3))
box on
xlabel('energy [eV]')
ylabel('beta')

figure(2) % attenuation length
subplot(1,2,1)
lbl_Len = load('Graphite_AttenuationLength.txt');
Angle = [0.02:0.001:0.2]';
l = XrayAttenuationLength('C', 2.2, 16000, Angle);
semilogy(Angle, l(:,1), '.r')
hold on
semilogy(lbl_Len(:,1), lbl_Len(:,2))
xlabel('angle [deg]')
ylabel('attenuation length')
box on
title('grazing angles')
subplot(1,2,2)
lbl_Len = load('Graphite_AttenuationLength_2.txt');
Angle = [60:1:90]';
l = XrayAttenuationLength('C', 2.2, 16000, Angle);
plot(Angle, l(:,1), '.r')
hold on
plot(lbl_Len(:,1), lbl_Len(:,2))
xlabel('angle [deg]')
ylabel('attenuation length')
box on
title('Normal angles')



figure(3) % index of refraction
lbl_R = load('Graphite_Reflectivity1.txt');
subplot(1,2,1)
R = XrayReflectivity('C', 2.2, 16000, [0.02:0.002:1], 1); 
semilogy([0.02:0.002:1], R(:,1), '.r')
hold on
semilogy(lbl_R(:,1), lbl_R(:,2))
xlabel('angle [deg]')
ylabel('Reflectivity')
title('pol=1')
lbl_R = load('Graphite_Reflectivity2.txt');
subplot(1,2,2)
R = XrayReflectivity('C', 2.2, 16000, [0.02:0.002:1], -1); 
semilogy([0.02:0.002:1], R(:,1), '.r')
hold on
semilogy(lbl_R(:,1), lbl_R(:,2))
xlabel('angle [deg]')
ylabel('Reflectivity')
title('pol=-1')