%

function ma1 = XrayMassAttenuationCoeff(Symbol, Energy)

% path(path,'XrayMassAttenuation') % Unix



[Z N] = ParseChemicalSymbol(Symbol);


ma1=zeros(size(Energy,2),size(Z,2));



for k=1:size(Z,2)
    
    load(strcat('xray_massatten_', num2str(Z(k)), '.mat'));
    ma(:,1) = ma(:,1)*1e3; % eV 

    % ind1 = find(ma(:,1)>Energy(1),1)

    for j=1:size(Energy,2)
        E = Energy(j);
        ind = find(ma(:,1)>E,1);

        if (size(ind,1) == 0) % higher than the highest energy
            ma1(j,k) = ma(size(ma,1),2);
        else
           if ind==1 % lower than the lowest energy
               ma1(j,k) = ma(1,2);
           else % within the dataset
               ma1(j,k) = (ma(ind,2)-ma(ind-1,2))/(ma(ind,1)-ma(ind-1,1))*(E-ma(ind-1,1)) + ma(ind-1,2); % linear interpolation
           end
        end

    end

end

%close all
%plot(ma(ind1:ind,1)/1000,ma(ind1:ind,2),'o')
%hold on
%plot(Energy/1000,ma1)
