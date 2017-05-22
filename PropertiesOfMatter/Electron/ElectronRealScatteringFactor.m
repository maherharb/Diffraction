% complex scattering factors from
% http://henke.lbl.gov/optical_constants/asf.html

function f0 = ElectronRealScatteringFactor(Z, s, FigNum)

    s = s/2; % Doyleand Turner define s as sin(theta)/lambda

    if nargin<2
        error('Insufficient number of inputs. You should supply the Atomic number and the scattering vector in 1/A. e.g. XrayRealScatteringFactor(6, 0.2)');
    end

    if size(s,2)>1
        s = s';
    end
    if size(s,1)==2
        s = linspace(s(1),s(2))';
    end

    load ElectronRealSF.mat
            
    f0 = ones(size(s,1),size(Z,2)); 
    for j=1:size(Z,2)
        f0(:,j) = 0; % c
        for i=1:5
            f0(:,j) = f0(:,j) + SF(Z(j),i)*exp(-SF(Z(j),i+5)*s.^2);
        end
    end

    if nargin>2 && length(s)>1 % plot result
        figure(FigNum)
        hold off
        plot(2*s, f0);
        xlabel('scattering vector = 2*sin(\theta)/\lambda [1/A]');
        ylabel('f_0')
    end

end


