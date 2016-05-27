% comparison between scripts and XOP
clear 

% DEFINE YOUR LATTICE OR LOAD LATTICE FROM EXISTING STRUCTURE LIBRARY
load graphite.mat

load xop_graphite.mat % XOP data 


Q_Range = [1 5];
s_scale = 2*pi; % converts s to q
hkl_space = [4:-1:-4];

Data = MultipeakIntensities(Lattice, hkl_space, 1e-10, Q_Range, s_scale, 2)

close all
figure(1)
subplot(2,1,1)
hold on
Data = sortrows(Data,4);
for j=1:size(Data,1)
    plot([Data(j,4) Data(j,4)], [0 sqrt(Data(j,5))], 'r', 'LineWidth', 2)   
    text(Data(j,4), sqrt(Data(j,5)), strcat('(', num2str(Data(j,1),0), num2str(Data(j,2),0), num2str(Data(j,3),0), ')'))
end
box on
xlabel('q [A^-^1]')
title('|F(h,k,l)|')
% XOP data
x = XOP(:,5); % d-spacing
x = 1./x*2*pi;
y = XOP(:,6); % sqrt(F)
z = XOP(:,8); % multiplicity
for j=1:length(x)
    if x(j)>Q_Range(1) && x(j)<Q_Range(2)
        plot(x(j),y(j),'o')
    end
end

subplot(2,1,2)
hold on
for j=1:size(Data,1)
    plot([Data(j,4) Data(j,4)], [0 Data(j,6)], 'r', 'LineWidth', 2)   
     plot([Data(j,4)], [Data(j,7)], 'or') 
    text(Data(j,4), Data(j,6), strcat('(', num2str(Data(j,1),0), num2str(Data(j,2),0), num2str(Data(j,3),0), ')'))
end
for j=1:length(x)
    if x(j)>Q_Range(1) && x(j)<Q_Range(2)
        plot(x(j),z(j),'o')
    end
end
title('Multiplicity')
xlabel('q [A^-^1]')


