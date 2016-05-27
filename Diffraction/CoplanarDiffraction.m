% COPLANARDIFFRACTION Sketches the diffraction geometry for the simple
% coplanar scenario (both symmetric and assymetric reflections).
%
% COPLANARDIFFRACTION(BRAGGANGLE, GRAZINGANGLE, SURFACENORMAL, REFLECTIONNORMAL, FIGNUM)
%   BRAGGANGLE: Bragg angle in deg. for the reflection of interest
%   ASSYMANGLE: Angle in deg. between reflection planes and crystal surface 
%       FIGNUM: Figure number in which to draw the diffraction geometry
%
% Note that a coplanar geometry can be realized only if the angle of
% assymetry (between reflection planes and surface) is smaller than the
% Bragg Angle. Hint: call the StructureFactor function to compute the angle
% of assymetry for (see example 2 below). 
%
% Example 1 (cubic lattice):
%   CoplanarDiffraction(60, 40, 1);
%
% Exampe 2 (hexagonal lattice):
%   load graphite.mat
%   Lattice.Normal = [0 0 1];
%   Lattice.Reflection = [1 0 8];
%   Probe.Type = 'xrays';
%   Probe.Energy = 15000;
%   SF = StructureFactor(Lattice, Probe);
%   CoplanarDiffraction(SF.BraggAngle, SF.AssymAngle, 1);
%
% Last update: 05-03-2011, Maher Harb

function CoplanarDiffraction(BraggAngle, AssymAngle, FigNum)

figure(FigNum)
hold off

a = AssymAngle*pi/180; % assymetry angle in rad.
if a<1e-4
    a=0;
end
b = BraggAngle*pi/180; % Bragg Angle in rad.

if imag(b)~=0
    title('oops! Bragg angle is imaginary! Diffraction condition cannot be met.')
else
    
    v = [0 0;1/tan(a) 1];
    
    % reference point
    x = 1.5;
    if a~=0
        x = 1/tan(a);
    end
    y = 1;
    
    r = floor(x*5)/5;
    
    
    % plot lattice planes
    for i=-r:0.2:3
        if ((x+i)<=1.5)
            d = i;
        end
    end
    x = x +d;
    
    % plot incident beam
    yi = 1 + tan(b-a)*x;
    plot([0 x], [yi y], 'g');
    hold on
    
    % plot reflected beam
    if (b+a)>pi/2
        yr = 1 + abs(tan(b+a))*(x);
        plot([0 x], [yr y], 'r');
    else
        yr = 1 + abs(tan(b+a))*(3-x);
        plot([3 x], [yr y], 'r');
    end
    
    % plot normal
    yn = 1 + tan(pi/2-a)*x;
    plot([0 x], [yn y], 'k');
    
    % extend plane along incidence point
    plot(linspace(x,x+1/tan(a),10), linspace(y,2,10), ':b')
    
    % plot incidence point
    plot(x,y,'.', 'MarkerSize', 12)
    
    % plot lattice planes
    for i=-r:0.2:3
        plot(v(:,1)+i, v(:,2))
    end
    
    % plot sufrace
    plot([0 3], [1 1], 'k', 'LineWidth', 2)
    plot([0 3], [0 0],  'k', 'LineWidth', 2)
    
    axis([0 3 -1 2])
    box on
    % axis off
    
    legend('incident', 'reflected', 'plane normal',  'Location', 'SouthEast')
    
    if a>b
        title('oops! Assymetry angle > Bragg angle!')
    else
        title(['Exit angle relative to surface = ', num2str(round(BraggAngle+AssymAngle)),' deg.'])
    end
    
end

end