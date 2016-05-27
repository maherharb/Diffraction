function R = ThinFilmReflectivity(Symbol1, Density1, Thickness1, Symbol2,  Density2, EnergyOrLambda, alpha, FigNum) 

 if size(EnergyOrLambda,2)>1
        EnergyOrLambda = EnergyOrLambda';
    end
    
    if size(EnergyOrLambda,1)==2
        if EnergyOrLambda(1)==EnergyOrLambda(2)
            EnergyOrLambda = EnergyOrLambda(1);
        else
            EnergyOrLambda = linspace(EnergyOrLambda(1),EnergyOrLambda(2))';
        end
    end
  
    if EnergyOrLambda(1)>1 % Energy
        Energy = EnergyOrLambda;
        lambda = Energy2lambda(Energy);
    else
        lambda = EnergyOrLambda;
    end
       
    if size(EnergyOrLambda,1)>1
        alpha = alpha(1);
    else
        if size(alpha,2)>1
            alpha = alpha';
        end
        if size(alpha,1)==2 
            if alpha(1)==alpha(2)
              alpha = alpha(1);
            else
                alpha = linspace(alpha(1), alpha(2))';
            end
        end
    end
    
n_film = XrayIndexOfRefraction(Symbol1, Density1, Energy);
n_film = 1-n_film(2)-1i*n_film(3);

n_substrate = XrayIndexOfRefraction(Symbol2,Density2, Energy);
n_substrate = 1-n_substrate(2)-1i*n_substrate(3);

alpha2 = pi/2-alpha;
alpha1 = asin(sin(alpha2)*real(1)/real(n_film));

n2 = n_film/1;
n1 = n_substrate/n_film;

K = 2*pi/lambda;

[rs2 rp2] = FresnelCoefficients2(1, n_film, alpha2);
[rs1 rp1] = FresnelCoefficients2(n_film,n_substrate, alpha1);

r2 = rs2;
r1 = rs1;

R = abs((r2+r1.*exp(-1i*2*K*n1*cos(alpha1)*Thickness1))./(1+r1.*r2.*exp(-1i*2*K*n1*cos(alpha1)*Thickness1))).^2;


   if nargin>7 % plot result
        figure(FigNum)
        subplot(1,1,1)
        hold off
        if size(EnergyOrLambda,1)>1
            if EnergyOrLambda(1)>1 % Energy
                plot(EnergyOrLambda, R);
                xlabel('Energy [eV]')
            else
                plot(EnergyOrLambda*1e10, R);
                xlabel(strcat(['Wavelength [', char(197), ']']))
            end
          %  title(strcat([Symbol, ': density = ', num2str(Density), ' g/cm^3.', ' Fixed grazing angle = ', num2str(alpha*180/pi,'%4.2f'), ' deg']))
            grid on;
        else
            semilogy((pi/2-alpha2)*180/pi, R);
            xlabel('Grazing angle [deg]')
            if EnergyOrLambda(1)>1 % Energy
          %      title(strcat([Symbol, ': density = ', num2str(Density), ' g/cm^3.', ' Fixed X-ray energy = ', num2str(round(EnergyOrLambda)), ' eV']))
            else
         %       title(strcat([Symbol, ': density = ', num2str(Density), ' g/cm^3.', ' Fixed X-ray wavelength = ', num2str(EnergyOrLambda*1e10,'%4.2f'), ' ', char(197), '.']))
            end
            hold on
         %  semilogy([(pi/2-asin(1 - sigma))*180/pi (pi/2-asin(1 - sigma))*180/pi], ylim, ':')
           legend('Reflectivity', 'Critical angle')
        end
        ylabel('X-ray Reflectivity')
    end
    
    if size(EnergyOrLambda,1)>1
        if EnergyOrLambda(1)>1 % Energy
            R = [EnergyOrLambda, R];
        else
            R = [EnergyOrLambda*1e10, R];
        end
    else
        R = [alpha*180/pi, R];
    end
