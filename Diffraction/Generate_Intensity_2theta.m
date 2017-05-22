%% Generate the XRD Pattern
% Generates a simulated powder x-ray diffraction pattern, a scatter plot
% with the intensities of individual reflection with the hkl value of one
% of the relfections in that family and a table with hkl, the Bragg Angle,
% Two Theta, the intensity and relative intensity, interlayer d spacing,
% 2pi/d, d_r (1/d) and m, the multiplicity.
% You can select the table to be outputed also as one of the extensions
% displayed at the initial user input.
%
% The function requires minimum of 2 inputs: Lattice and Probe 
% GENERATE_INTENSITY_2THETA(LATTICE, PROBE) generates the powder x-ray
% pattern and the table with indeces between 0 and 8 and with Threshold=1
% and Separation-0.1;
%
% GENERATE_INTENSITY_2THETA(LATTICE, PROBE,FIGNUM) Gives just the powder x-ray
% pattern and the table with a Threshold=1 and Separation=0.1 and hkl=6;
%
% GENERATE_INTENSITY_2THETA(LATTICE, PROBE,FIGNUM,HKL) Gives the x-ray
% pattern, the table with Threshold=1 and Separation=0.1;
%
% If for high hkl values, you don't get all the expected information in the
% table, it might be because the separation between the peaks is too high.
% Consider decreasing it.
%
%
% Last updated 5-17-2017 Cosmin Popescu

function [Table]=Generate_Intensity_2theta(Lattice, Probe,FigNum,hkl,Threshold, Separation)
%% Get the XRD Pattern

%% Loop over different hkl values individually.
% Go through all combinations given by user of Miller
% indeces and returns the resulting information from Structure Factor. If
% the Bragg angle is real and the intensity is above a threshold, these
% values are save.

% Promt user for input on type of file output at the end.
TypeOfFile=input('What kind of file extension do you want?\nOptions: nothing (press Enter), txt, xlsx, xls, dat, csv \n','s');


MainData=zeros(10,4);
countofdata=1;
% Check for user input. Fill in if not input. 
if nargin <4
   hkl=6; 
end
if nargin<5
    Threshold=1;
    Separation=0.1;
elseif nargin<6
    Separation=0.1;
end


for h=hkl:-1:-hkl
    for k=hkl:-1:-hkl
        for l=hkl:-1:-hkl
            if h==0 && k==0 && l==0
                % This is to eliminate the 000
            else
                
                Lattice.Reflection=[h k l];
                [Result,Lattice,Probe]= StructureFactor(Lattice,Probe);
                if Result.Intensity>Threshold && isreal(Result.BraggAngle)
                    
                    MainData(countofdata,1)=h;
                    MainData(countofdata,2)=k;
                    MainData(countofdata,3)=l;
                    MainData(countofdata,4)=Result.Intensity;
                    MainData(countofdata,5)=2*Result.BraggAngle;
                    MainData(countofdata,6)=Result.Distance;
                    countofdata=countofdata+1;
                end
            end
        end
    end
end


length=size(MainData,1);


%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

%% Sort everything by the Bragg angle.
% It uses a bubble sort to rearrange all rows based on the twotheta.

sorted=false;
while sorted==false
    n=1;
    while n<length
        if MainData(n,5)>MainData(n+1,5)
            % If it finds a place where it is not sorted, it rearranges the
            % two rows and restarts going through all lines. It needs
            % changed to speed up the process because this is the slowest
            % algorithm for sorting and the only one I had in mind then.
            store=MainData(n+1,:);
            MainData(n+1,:)=MainData(n,:);
            MainData(n,:)=store;
            n=1;
        else
            n=n+1;
        end
    end
    sorted=true;
end


% Potential merge sort fail.
% SortedData=zeros(size(MainData,1),size(MainData,2));
% SortedData=TopDownMergeSort(MainData,SortedData,size(MainData,2),5);
% MainData=SortedData;



%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


%% Make scatter plot with relative intensities of each reflection

if nargin>2
    figure(FigNum)
else
    figure
end
    plot(MainData(:,5),MainData(:,4),'ob','linewidth',2);
    xlabel('2\theta');
    ylabel('Intensity');
    Title=strcat(Lattice.Symbol,'-',Lattice.Type);
    title(Title);
    axis([0 180 0 1.1*max(MainData(:,4))]);
    hold on;


%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

%% Add the Miller indeces to the plot
xseparation=-2;
yseparation=max(MainData(:,4))*0.05;
% This is a way to separate multiple combinations of hkl that give the same
% theta.
MainData(:,7)=ones(length,1);
for i=2:length
    if MainData(i,5)==MainData(i-1,5)
        MainData(i,7)=MainData(i-1,7)+1;
    end
end
% Write text at a separation from the point. If multiple point in the same
% location, stack the hkl in order defined by previous for.

    for i=1:length
        if MainData(i,7)==1
            H=MainData(i,1);
            K=MainData(i,2);
            L=MainData(i,3);
            text( MainData(i,5)+xseparation,MainData(i,4)+yseparation,strcat([num2str(H), num2str(K), num2str(L)]))
        end
    end


%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

%% Intensities on the same angle are added up

MainData(:,8)=MainData(:,4);

for i=1:length
    n=i;
    currentposition=i;
    if(n<length-1)
        while(MainData(n+1,7)>1)
            % if it sees a higher values for its occurence for the next
            % spot, it means that the next spot has the same Bragg angle
            % meaning it comes fomr the same family of reflection so it
            % adds up the intensity
            MainData(currentposition,8)=MainData(currentposition,8)+MainData(n+1,8);
            MainData(n+1,8)=0;
            if(n+1<length)
                n=n+1;
            else
                break
            end
        end
    else
        if(MainData(n,7)==1)
            MainData(n,8)=MainData(n,4);
        end
    end
    
end


%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

%% Generating XRD plot with separation between the peaks based on user input or default.

if nargin>2
    figure(FigNum+1)
else % default
    figure
end
countAngle=1;
XRD_plot=zeros(ceil(180/Separation+length),5);
indexPlot=1;
ArrayIndex=1;
maxI=max(MainData(:,8));
for angle=0:Separation:180
    if (angle<MainData(countAngle,5))&& (angle+Separation>MainData(countAngle,5)&&countAngle<length-1)
        % Collect data for the table.
        Table.h=MainData(countAngle,1); %h
        Table.k=MainData(countAngle,2); %k
        Table.l=MainData(countAngle,3); %l
        Table.BraggAngle=MainData(countAngle,5)/2;
        Table.TwoTheta=MainData(countAngle,5);
        Table.Intensity=MainData(countAngle,8);
        Table.RelativeIntensity=Table.Intensity/maxI*100;
        Table.d=MainData(countAngle,6);
        Table.TwoPi_Distance=2*pi/Table.d;
        Table.d_r=1/Table.d;
        
        XRD_plot(indexPlot,1)=MainData(countAngle,5); %2theta
        XRD_plot(indexPlot,2)=MainData(countAngle,8); %Intensity of the actual point
        indexPlot=indexPlot+1;
        
        if countAngle<length
            while(MainData(countAngle+1,7)>1)
                if countAngle<length-1
                    countAngle=countAngle+1;
                else
                    countAngle=length;
                    break;
                end
            end
        end
        
        Table.m=MainData(countAngle,7);
        Array(ArrayIndex)=Table;
        ArrayIndex=ArrayIndex+1;
        if countAngle<length
            if MainData(countAngle+1,5)-MainData(countAngle,5)<Separation
                warning('The separation between some peaks is less than the Separation.\n Please decrease the value for Separation.');
                display(MainData(countAngle,5));
                display(MainData(countAngle+1,5));
                display(MainData(countAngle,7));
                display(MainData(countAngle+1,7));
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

hold on;
plot(XRD_plot(:,1),XRD_plot(:,2)*100/max(XRD_plot(:,2)),'-b','linewidth',1.5);
xlabel('2\theta');
ylabel('Intensity percent I/I_M_a_x');
Title=strcat(Lattice.Symbol,'-',Lattice.Type,'- ',num2str(Probe.Energy),'eV');
title(Title);
axis([0 180 0 105]);
hold on;

legend('MATLAB');

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% Make table with Miller indeces.
Table=struct2table(Array);
time=datestr(datetime('now'));
time(15)='_';
time(18)='_';
time(12)='_';
NameOFile=strcat(Lattice.Symbol,'_',Lattice.Type,'_',num2str(Probe.Energy),'eV','_',time,'.');

if size(TypeOfFile,2)==4
    if TypeOfFile=='xlsx'
        writetable(Table,strcat(NameOFile,'xlsx'));
    end
elseif size(TypeOfFile,2)==3
    if TypeOfFile== 'txt'
        writetable(Table,strcat(NameOFile,'txt'));
    elseif TypeOfFile=='dat'
        writetable(Table,strcat(NameOFile,'dat'));
    elseif TypeOfFile == 'csv'
        writetable(Table,strcat(NameOFile,'csv'));
    elseif TypeOfFile == 'xls'
        writetable(Table,strcat(NameOFile,'xls'));
    end
else %default do nothing
end