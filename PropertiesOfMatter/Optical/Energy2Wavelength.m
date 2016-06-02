function lambda = Energy2Wavelength(E, m)

    SPEED_LIGHT = 299792458; % speed of light [m]
    ELEMENTARY_CHARGE = 1.60217662e-19; %
    PLANCK = 6.626070040e-34; % h [J]

    if nargin<2 % x-ray, light
         lambda = PLANCK*SPEED_LIGHT./E/ELEMENTARY_CHARGE; % [m]
    else % matter
         Gamma = E*ELEMENTARY_CHARGE/(m*SPEED_LIGHT^2)+1;
         Velocity = sqrt(1-1/(Gamma^2))*SPEED_LIGHT;
        lambda = PLANCK/(Gamma*Velocity*m);
    end
    
end