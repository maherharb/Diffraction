% lbl scattering factors
clear 
home

D = load('lbl_C_scattering_factors.txt');
% D = load('lbl_Au_scattering_factors.txt');
sf = XrayComplexScatteringFactor2(6, [10:10:30000]');

close all
figure(1)
subplot(1,2,1)
plot(D(:,1)/1000,D(:,2), '.')
hold on
plot([10:10:30000]'/1000, sf(:,1), 'r')


subplot(1,2,2)
plot(D(:,1)/1000,D(:,3), '.')
hold on
plot([10:10:30000]'/1000, sf(:,2), 'r')