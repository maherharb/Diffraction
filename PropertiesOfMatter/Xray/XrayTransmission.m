
function T = XrayTransmission(Symbol, Density, EnergyOrLambda, Thickness, FigNum) 


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
  
    if EnergyOrLambda(1) >1 % Energy
        Energy = EnergyOrLambda;
        lambda = Energy2lambda(Energy);
    else
        lambda = EnergyOrLambda;
        Energy = lambda2Energy(lambda);
    end
    
    if size(EnergyOrLambda,1)>1
        Thickness = Thickness(1);
    else
        if size(Thickness,2)>1
            Thickness = Thickness';
        end
        if size(Thickness,1)==2 
            if  Thickness(1)== Thickness(2)
               Thickness =  Thickness(1);
            else
                 Thickness = linspace( Thickness(1),  Thickness(2))';
            end
        end
    end
    
    [Z N] = ParseChemicalSymbol(Symbol);
    M = GetAtomicMass(Z);
     
    RADIUS_ELECTRON = 2.817940325e-15; % electron radius [m]
    N_A = 6.0221415e23;     
    
    [f1 f2] = XrayComplexScatteringFactor(Z, Energy);
    
     mu_a = 0;
    if length(Z)==1 % elements
        mu_a = 2*RADIUS_ELECTRON*lambda.*f2;  % photoabsorption cross section
        T = exp(-N*Density*1e6/M*mu_a*Thickness*N_A);
    else    
        for i=1:length(Z) % molecules
            mu_a = mu_a + 2*RADIUS_ELECTRON*lambda.*f2(:,i)*N(i);
        end
        T = exp(-Density*1e6/sum(M.*N)*mu_a*Thickness*N_A);
    end
    
    if nargin>4 && (length(EnergyOrLambda)>1 || length(Thickness)>1) % plot result
        figure(FigNum)
        hold off
        
        if size(EnergyOrLambda,1)>1
            if EnergyOrLambda(1)>1 % Energy
                plot(EnergyOrLambda, T);
                xlabel('Energy [eV]')
            else
                plot(EnergyOrLambda*1e10, T);
                xlabel(strcat(['Wavelength [', char(197), ']']))
            end
            title(strcat(['Fixed thickness = ', num2str(Thickness*1e6,'%4.2f'), ' \mum']))
            grid on;
        else
            plot(Thickness*1e6, T);
            xlabel('Thickness [\mum]')
            if EnergyOrLambda(1)>1 % Energy
                title(strcat(['Fixed X-ray energy = ', num2str(round(EnergyOrLambda)), ' eV']))
            else
                title(strcat(['Fixed X-ray wavelength = ', num2str(EnergyOrLambda*1e10,'%4.2f'), ' ', char(197)]))
            end
        end
        ylabel('X-ray Transmission')
    end
    
    if size(EnergyOrLambda,1)>1
        if EnergyOrLambda(1)>1 % Energy
            T = [EnergyOrLambda, T];
        else
            T = [EnergyOrLambda*1e10, T];
        end
    else
        T = [Thickness*1e6, T];
    end
    

end
    
    