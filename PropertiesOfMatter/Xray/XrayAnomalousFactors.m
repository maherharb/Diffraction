% XRAYANOMALOUSFACTORS Calculate the x-ray anomalous scattering factors in
% the 10-30000 eV energy range (based on data files from CXRO); and
% (optional) Plot the anomalous scattering factors vs. x-ray energy.
%
% [SF1 SF2] = XRAYANOMALOUSFACTORS(Z, ENERGY, FIGNUM)
%           Z: Atomic number of the element
%      ENERGY: X-ray energy in eV
%      FIGNUM: (optional) Figure number in which to plot the anomalous scattering factors
%         SF1: Real part of the anomalous scattering factor
%         SF2: Imaginary part of the anomalous scattering factor
%
% Multiple calculations can be made at once by providing an array of atomic
% numbers Z, and an array of energies ENERGY. In that case, the returned
% SF1 and SF2 are matrices where columns correspond to atomic numbers and
% rows to energies (see example 1).
%
% If ENERGY is a 2 element vector, the calculation is made for 501 points
% within the range specified by ENERGY (see example 2).
%
% Example 1 (anomalous scattering factors for silicon and oxygen):
%   [sf1 sf2] = XrayAnomalousFactors([14 8], [1000 5000 10000 20000])
%
% Example 2 (anomalous scattering factors for carbon):
%   [sf1 sf2] = XrayAnomalousFactors(6, [1000 30000], 1)
%
% Last update: 06-03-2011, Maher Harb

function [sf1 sf2] = XrayAnomalousFactors(Z, Energy, FigNum)

if nargin<2
    error('Insufficient number of input arguments. Type "help XrayAnomalousFactors" to learn more.');
end

if size(Energy,2)>1
    Energy = Energy';
end
if size(Energy,1)==2
    Energy = linspace(Energy(1),Energy(2), 501)';
end

if Energy(1)<10 || Energy(length(Energy))>30000
    warning('Some of the energy values are outside the 10-30000 eV range.')
end

sf1=zeros(length(Energy),length(Z));
sf2=zeros(length(Energy),length(Z));

for i=1:length(Energy)
    E = Energy(i);
    for j=1:length(Z)
        
        load(strcat('xray_sf_', num2str(Z(j)), '.mat'));
        
        ind = find(sf(:,1)>E,1);
        
        if (size(ind,1) == 0) % higher than the highest energy
            sf1(i,j) = sf(size(sf,1),2);
            sf2(i,j) = sf(size(sf,1),3);
        else
            if ind==1 % lower than the lowest energy
                sf1(i,j) = sf(1,2);
                sf2(i,j) = sf(1,3);
            else % within the dataset
                sf1(i,j) = (sf(ind,2)-sf(ind-1,2))/(sf(ind,1)-sf(ind-1,1))*(E-sf(ind-1,1)) + sf(ind-1,2); % linear interpolation
                sf2(i,j) = (sf(ind,3)-sf(ind-1,3))/(sf(ind,1)-sf(ind-1,1))*(E-sf(ind-1,1)) + sf(ind-1,3); % linear interpolation
            end
        end
    end
end

if nargin>2 && length(Energy)>1 % plot result
    figure(FigNum)
    for i=1:length(Z)
    subplot(1,2,1)
    plot(Energy/1000, sf1(:,i),'DisplayName',GetElementSymbol(Z(i)),'linewidth',2); 
    hold on
    xlabel('Energy (KeV)');
    ylabel('f^''')
    
    subplot(1,2,2)
    plot(Energy/1000, sf2(:,i),'DisplayName',GetElementSymbol(Z(i)),'linewidth',2);
    hold on
    legend('-DynamicLegend','location','best');
    ylabel('f^''^''')
    xlabel('Energy (KeV)');
    end
end

end


