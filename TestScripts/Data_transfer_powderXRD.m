function [XRD_plot,Data]=Data_transfer_powderXRD(Data,Resolution,FigNum)
[length,~]=size(Data);
%% Sort by Bragg Angle and retain multiplicities
sorted=false;
while sorted==false
    n=1;
   while n<length-1
        if Data(n,1)>Data(n+1,1)
            
            store=Data(n+1,:);
            Data(n+1,:)=Data(n,:);
            Data(n,:)=store;
            n=1;
        else 
            n=n+1;
        end
   
   end
   sorted=true;
    
end
%%
Data(:,6)=ones(length,1);
for i=2:length
    if Data(i,1)==Data(i-1,1)
        Data(i,6)=Data(i-1,6)+1;
    end
end
%% Intensities are added up by multiplicities
Data(:,3)=zeros(length,1);
Data(:,4)=Data(:,2);

for i=1:length
    n=i;
    currentposition=i;
    if(n<length-1)
        while(Data(n+1,6)>1)
            Data(currentposition,4)=Data(currentposition,4)+Data(n+1,4);
            Data(n+1,8)=0;
            if(n+1<length)
            n=n+1;
            else
                break
            end
        end
    else
        if(Data(n,6)==1)
            Data(n,4)=Data(n,4);
        end
    end
    
end
%% Make plot
countAngle=1;
XRD_plot=zeros(ceil(180/Resolution+length),2);
indexPlot=1;
for angle=0:Resolution:180
    if (angle<Data(countAngle,1))&& (angle+Resolution>Data(countAngle,1)&&countAngle<=length)
        XRD_plot(indexPlot,1)=Data(countAngle,1); %2theta
        XRD_plot(indexPlot,2)=Data(countAngle,4); %Intensity of the actual point
        indexPlot=indexPlot+1;
        if countAngle<length
            while(Data(countAngle+1,6)>1&&(countAngle<(length-1)))
                countAngle=countAngle+1;
            end
        end
        if countAngle<length
        countAngle=countAngle+1;
        end
    else
        XRD_plot(indexPlot,1)=angle; %Looping through the angles.
        XRD_plot(indexPlot,2)=0; %No intensity
        indexPlot=indexPlot+1;
        
    end       
end

figure(FigNum);
% subplot(2,1,2);
plot(XRD_plot(:,1),110+XRD_plot(:,2),'-r','linewidth',1.5);
xlabel('2\theta');
ylabel('Intensity percent I/I_M_a_x');
legend('MATLAB','Crystal Diffract');
axis([0 180 0 220]);