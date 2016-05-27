function Data = MultipeakIntensities(Lattice, Probe, hkl_space, Q_Range, s_scale, FigNum, pltColors, KeepFigOpen) % Q = s = 1/d

% save MultipeakIntensities.mat Lattice hkl_space EnergyOrLambda Q_Range s_scale FigNum

   
    Data = [] ;


        for h = hkl_space
            for k = hkl_space
                for l = hkl_space
                    Lattice.Reflection = [h k l];
                    [Result Lattice Probe] = StructureFactor(Lattice, Probe); % hexagonal diamond
                    Result.ScatteringVector = round(Result.ScatteringVector*10000)/10000;
                    if (abs(k)+abs(h)+abs(l))~=0 && Result.Intensity>1e-10 && Result.ScatteringVector*s_scale>Q_Range(1) && Result.ScatteringVector*s_scale<Q_Range(2)
                        if size(Data,1)>0
                            if size(find(Data(:,5)==Result.ScatteringVector),1)==0
                                Data = [Data; h k l Result.Distance Result.ScatteringVector Result.ScatteringVector*2*pi sqrt(Result.Intensity) 1 Result.Multiplicity Result.BraggAngle 90-Result.AssymAngle];
                            else
                                indx = find(Data(:,5)==Result.ScatteringVector,1);
                                % Data(indx,5) = Data(indx,5) + Result.Intensity;
                                Data(indx,8) = Data(indx,8) + 1;
                            end
                        else
                            Data = [Data; h k l Result.Distance Result.ScatteringVector Result.ScatteringVector*2*pi sqrt(Result.Intensity) 1 Result.Multiplicity Result.BraggAngle 90-Result.AssymAngle];
                        end
                    end
                end
            end
        end

  
    if nargin>5
        figure(FigNum)
        
        if nargin==6
            pltColors = 'k';
        end    
        
        
        if nargin>7
            if KeepFigOpen==1
                
            else
                close(FigNum)
                figure(FigNum)
            end
        else
            close(FigNum)
            figure(FigNum)
        end
        
        
        subplot(2,1,2)
        hold on
        subplot(2,1,1)
        hold on

    
    if sum(size(Data)) == 0
            subplot(2,1,1)
        title('No peaks within specified range')
        box on
        subplot(2,1,2)
        title('No peaks within specified range')
        box on
    else
            Data = sortrows(Data,5);
            x_in_2theta =  2*asin(Probe.lambda*1e10*Data(:,5)/2)*180/pi; %2theta
            for j=1:size(Data,1)
                subplot(2,1,1)
                plot([Data(j,5)*s_scale Data(j,5)*s_scale], [0 Data(j,7)], pltColors, 'LineWidth', 2)   
                text(Data(j,5)*s_scale, Data(j,7), strcat('(', num2str(Data(j,1),0), num2str(Data(j,2),0), num2str(Data(j,3),0), ')'))
                subplot(2,1,2)
                if imag(x_in_2theta(j))==0
                    plot([x_in_2theta(j) x_in_2theta(j)], [0 Data(j,7)], pltColors, 'LineWidth', 2)   
                end
                text(x_in_2theta(j), Data(j,7), strcat('(', num2str(Data(j,1),0), num2str(Data(j,2),0), num2str(Data(j,3),0), ')'))
            end

        subplot(2,1,1)
        box on
        xlabel(strcat(['s [A^-^1] x', num2str(s_scale)]))
        ylabel('|F(h,k,l)|')
        axis([Q_Range ylim])
        subplot(2,1,2)
        box on
        title(strcat(['at x-ray energy = ', num2str(Probe.Energy) ,' eV']))
        xlabel('2\theta [deg]')
        ylabel('|F(h,k,l)|')        
    end

    end
    
end




