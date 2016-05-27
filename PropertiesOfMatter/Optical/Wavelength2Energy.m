function E = Wavelength2Energy(lambda, m)

    SPEED_OF_LIGHT = 299792458; % speed of light [m]
    ELEMENTARY_CHARGE = 1.6e-19; %
    PLANCK = 6.626068e-34; % h [J]

    if nargin<2 % x-ray, light
         E = PLANCK*SPEED_OF_LIGHT./lambda/ELEMENTARY_CHARGE; % [m]
    else % matter
         Momentum = PLANCK/lambda ;
            E = (sqrt(m^2* SPEED_OF_LIGHT^4 + Momentum^2*SPEED_OF_LIGHT^2) - m*SPEED_OF_LIGHT^2)/ELEMENTARY_CHARGE;
    end
    
end