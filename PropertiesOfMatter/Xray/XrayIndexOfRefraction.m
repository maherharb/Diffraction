% XRAYINDEXOFREFRACTION Calculate the x-ray index of refraction
% (1-delta)-i*(beta); and (optional) Plot delta and beta vs. energy or
% wavelength.
%
% XRAYINDEXOFREFRACTION(SYMBOL, DENSITY, ENERGYORWAVELENGTH, FIGNUM, PLOTPARAMS)
%              SYMBOL: Chemical symbol of the molecule
%             DENSITY: Density in grams per cubic centimeter
%  ENERGYORWAVELENGTH: x-ray energy in eV or x-ray wavelength in Angstrom
%              FIGNUM: (optional) Figure number in which to plot the index of refraction
%          PLOTPARAMS: (optional) string defining the plot options (color, marker, line style, etc.)
%
% Index of refraction vs. energy (wavelength) is plotted if
% ENERGYORWAVELENGTH is a vector. If ENERGYORWAVELENGTH is a 2 element
% vector, the index of refraction is calculated for 501 points within the
% range specified by ENERGYORWAVELENGTH.
%
% Example 1 (x-ray index of refraction vs. energy):
%   XrayIndexOfRefraction('Ag', 10.5, [1000 5000], 1, '-b')
%   XrayIndexOfRefraction('Au', 19.3, [1000 5000], 1, ':r')
%
% Exampe 2 (x-ray index of refraction vs. wavelength):
%   XrayIndexOfRefraction('InSb', 5.7, [0.2 2], 2)
%
% Last update: 28-02-2011, Maher Harb

function n = XrayIndexOfRefraction(Symbol, Density, EnergyOrWavelength, FigNum, PlotParams)

if size(EnergyOrWavelength,2)>1
    EnergyOrWavelength = EnergyOrWavelength';
end

if size(EnergyOrWavelength,1)==2
    if EnergyOrWavelength(1)==EnergyOrWavelength(2)
        EnergyOrWavelength = EnergyOrWavelength(1);
    else
        EnergyOrWavelength = linspace(EnergyOrWavelength(1),EnergyOrWavelength(2),501)';
    end
end

if EnergyOrWavelength(1)>10 % Energy
    Energy = EnergyOrWavelength; % eV
    lambda = Energy2Wavelength(Energy);
else
    lambda = EnergyOrWavelength*1e-10; % m
    Energy = Wavelength2Energy(lambda);
end

[Z N] = ParseChemicalSymbol(Symbol);
M = GetAtomicMass(Z);

n = zeros(size(EnergyOrWavelength,1),2);

RADIUS_ELECTRON = 2.817940325e-15; % electron radius [m]
N_A = 6.0221415e23;

[f1 f2] = XrayAnomalousFactors(Z, Energy);

%f1

%f2

if length(Z)==1 % elements
    n(:,1) = RADIUS_ELECTRON*lambda.^2*N*Density*1e6/(2*pi*M).*f1*N_A;
    n(:,2) = RADIUS_ELECTRON*lambda.^2*N*Density*1e6/(2*pi*M).*f2*N_A;
else
    for i=1:length(Z) % molecules
        n(:,1) = n(:,1) + RADIUS_ELECTRON*lambda.^2*N(i)*Density*1e6/(2*pi*sum(M.*N)).*f1(:,i)*N_A;
        n(:,2) = n(:,2) + RADIUS_ELECTRON*lambda.^2*N(i)*Density*1e6/(2*pi*sum(M.*N)).*f2(:,i)*N_A;
    end
end

if nargin>3 && length(EnergyOrWavelength)>1 % plot result
    figure(FigNum)
    
    if nargin>4
        PltClr = PlotParams;
    else
        PltClr = 'b';
    end
    
    if EnergyOrWavelength(1)>1 % vs. energy
        subplot(1,2,1)
        [~, ~, ~, l_text] = legend;
        semilogy(EnergyOrWavelength/1000, n(:,1), PltClr);
        hold on
        xlabel('Energy (KeV)')
        ylabel('delta')
        title('n = (1-delta) - i (beta)')
        legend(l_text, Symbol)
        box on;
        
        subplot(1,2,2)
        [~, ~, ~, l_text] = legend;
        semilogy(EnergyOrWavelength/1000, n(:,2), PltClr);
        hold on
        xlabel('Energy (KeV)')
        ylabel('beta')
        title('n = (1-delta) - i (beta)')
        legend(l_text, Symbol)
        box on;
        
    else % vs. wavelength
        subplot(1,2,1)
        [~, ~, ~, l_text] = legend;
        hold on
        semilogy(EnergyOrWavelength, n(:,1), PltClr);
        xlabel(strcat(['Wavelength (', char(197), ')']))
        ylabel('delta')
        title('n = (1-delta) - i (beta)')
        legend(l_text, Symbol)
        box on;
        
        subplot(1,2,2)
        [~, ~, ~, l_text] = legend;
        hold on
        semilogy(EnergyOrWavelength, n(:,2), PltClr);
        xlabel(strcat(['Wavelength (', char(197), ')']))
        ylabel('beta')
        title('n = (1-delta) - i (beta)')
        legend(l_text, Symbol)
        box on;
    end
end

end

