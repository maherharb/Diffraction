% XRAYATTENUATIONLENGTH Calculate the x-ray attenuation length in microns
% based on linear absorption and evanescent absorption (Reference: Phys.
% Rev. B 35, 2137); and (optional) Plot the attenuation length vs. energy,
% wavelength or angle of incidence.
%
% XRAYATTENUATIONLENGTH(SYMBOL, DENSITY, ENERGYORWAVELENGTH, GRAZINGANGLE, FIGNUM)
%              SYMBOL: Chemical symbol of the molecule
%             DENSITY: Density in grams per cubic centimeter
%  ENERGYORWAVELENGTH: x-ray energy in eV or x-ray wavelength in Angstrom
%        GRAZINGANGLE: Angle of incidence relative to surface in degrees
%              FIGNUM: (optional) Figure number in which to plot the attentuation length
%          PLOTPARAMS: (optional) string defining the plot options (color, marker, line style, etc.)
%
% Attentuation length vs. energy (wavelength) is plotted if
% ENERGYORWAVELENGTH is a vector. Attentuation length vs. angle of
% incidence is plotted if INCIDENCEANGLE is a vector. If ENERGYORWAVELENGTH
% or INCIDENCEANGLE is a 2 element vector, the attenuation length is
% calculated for 501 points wihin the range specified by ENERGYORWAVELENGTH
% or INCIDENCEANGLE.
%
% Example 1 (x-ray attenuation length vs. energy at normal incidence):
%   XrayAttenuationLength('C', 2, [1000 20000], 90, 1)
%
% Exampe 2 (x-ray attenuation length vs. wavelength at 1 deg. grazing incidence):
%   XrayAttenuationLength('C', 2, [0.5 2], 1, 2)
%
% Exampe 3 (x-ray attenuation length vs. incidence angle):
%   XrayAttenuationLength('InSb', 5.7, 10000, [0 0.5], 3)
%
% Last update: 28-02-2011, Maher Harb


function l = XrayAttenuationLength(Symbol, Density, EnergyOrWavelength, GrazingAngle, FigNum, PlotParams)


GrazingAngle = GrazingAngle*pi/180; % convert to rad

if size(EnergyOrWavelength,2)>1
    EnergyOrWavelength = EnergyOrWavelength';
end

if size(EnergyOrWavelength,1)==2
    if EnergyOrWavelength(1)==EnergyOrWavelength(2)
        EnergyOrWavelength = EnergyOrWavelength(1);
    else
        EnergyOrWavelength = linspace(EnergyOrWavelength(1),EnergyOrWavelength(2), 501)';
    end
end

if EnergyOrWavelength(1)>10 % Energy
    Energy = EnergyOrWavelength;
    lambda = Energy2Wavelength(Energy);
else
    lambda = EnergyOrWavelength*1e-10; % wavelength in m
end

if size(EnergyOrWavelength,1)>1
    GrazingAngle = GrazingAngle(1);
else
    if size(GrazingAngle,2)>1
        GrazingAngle = GrazingAngle';
    end
    if size(GrazingAngle,1)==2
        if GrazingAngle(1)==GrazingAngle(2)
            GrazingAngle = GrazingAngle(1);
        else
            GrazingAngle = linspace(GrazingAngle(1), GrazingAngle(2), 501)';
        end
    end
end

IndexOfRefraction = XrayIndexOfRefraction(Symbol, Density, EnergyOrWavelength);
sigma = IndexOfRefraction(:,1);
beta = IndexOfRefraction(:,2);
% beta = 7.9e-10;


% ma = XrayMassAttenuationCoeff(Symbol, Energy);
% display(1/(ma*Density*1e2)*1e6);

ac = pi/2-asin(1-sigma);
l = zeros(length(GrazingAngle),1);
ind = find(GrazingAngle>ac,1);
a = 2^-0.5*sqrt((2*sigma-sin(GrazingAngle).^2)+((sin(GrazingAngle).^2-2*sigma).^2+(2*beta).^2).^0.5); % Phys Rev B, 35, 2137



if size(ind ,2)==0
    l = lambda./(4*pi*a)*1e6;
else
    if ind==1
        l = lambda*sin(GrazingAngle)./(4*pi*beta)*1e6; % should be 8pi, but 4pi is giving results like cxro! lambda*sin(GrazingAngle)./(4*pi*beta)*1e6
    else
        l(1:ind) = lambda./(4*pi*a(1:ind))*1e6;
        l(ind+1:length(l)) = lambda*sin(GrazingAngle(ind+1:length(l)))./(4*pi*beta)*1e6; % should be 8pi, but 4pi is giving results like cxro!
    end
end


GrazingAngle = GrazingAngle*180/pi; % convert back to deg.

if nargin>4 && (length(EnergyOrWavelength)>1 || length(GrazingAngle)>1) % plot result
    figure(FigNum)
    [~, ~, ~, l_text] = legend;
    
    if nargin>5
        PltClr = PlotParams;
    else
        PltClr = 'b';
    end
    
    if size(EnergyOrWavelength,1)>1
        if EnergyOrWavelength(1)>1 % Energy
            plot(EnergyOrWavelength/1000, l, PltClr);
            xlabel('Energy (KeV)')
        else
            plot(EnergyOrWavelength, l, PltClr);
            xlabel(strcat(['Wavelength (', char(197), ')']))
        end
        title(strcat(['X-ray grazing angle = ', num2str(GrazingAngle,'%4.2f'), ' deg']))
        legend(l_text, Symbol)
    else
        semilogy(GrazingAngle, l, PltClr);
        xlabel('Incidence angle (deg)')
        if EnergyOrWavelength(1)>1 % Energy
            title(strcat(['X-ray energy = ', num2str(round(EnergyOrWavelength/1000)), ' KeV']))
        else
            title(strcat(['X-ray wavelength = ', num2str(EnergyOrWavelength,'%4.2f'), ' ', char(197)]))
        end
        legend(l_text, Symbol)
        % semilogy([(pi/2-asin(1 - sigma))*180/pi (pi/2-asin(1 - sigma))*180/pi], ylim, ':')
        % legend('Attenuation length', 'Critical angle', 'Location', 'NorthEast')
    end
    ylabel('X-ray Attenuation length (\mum)')
    hold on
end

end

