% created for noncoplanar grazing incidence x-ray diffraction
% Probe.psi is grazing angle in degrees (small)
% Last updates 4-26-2017 Cosmin Popescu

function [I,Table] = GeometricalSimulation1(Lattice, Probe, Detector, hkl_space, FigNum)

% save GeometricalSimulation1.mat Lattice Probe Crystal Detector hkl_space


% Input extension to save data
TypeOfFile=input('What kind of file extension do you want?\nOptions: nothing (press Enter), txt, xlsx, xls, dat, csv \n','s');


% Original program starts here
I = zeros(3000,3000);
PixelsPerUnit = size(I,1)/Detector.Size;
dy = Detector.DistanceToSample*tan((Probe.psi)*pi/180);

% Check the shape of the detector. If no input, assume square.
if isfield(Lattice,'Shape')==0  % default
    Detector.Shape =  'square';
end


% If a number for the figure is in input, generate figure no# FigNum.
% Proceed to plot the main ray point. No crystalographic value.
if nargin>4 % plot result
    figure(FigNum)
    subplot(1,2,1)
     hold off
    plot(0-Detector.Offset(1), -dy-Detector.Offset(2), 'o', 'LineWidth', 2)
    hold on
end

xy_space = [0 0];


% Loop over hkl and output image
index=1;
Old_Theta_I=[];
Old_Theta_R=[];


for k = hkl_space
    for h = hkl_space
        
        for l = hkl_space
            % Generate the reflection directions (using Miller indeces).
            Lattice.Reflection = [h k l];
            [SF, Lattice, Probe] = StructureFactor(Lattice, Probe); % CALCULATE THE STRUCTURE FACTOR
            
            
            % If the Bragg angle is smaller than the asymmetric angle.
            if SF.BraggAngle<SF.AssymAngle
                
                
                % Use NonCoplanarDiffraction script to obtain the result.
                Result = NonCoplanarDiffraction(SF.BraggAngle, Probe.psi, SF.CrystalNormal, SF.ReflectionNormal); %% && Result.ReflectedSpherical(2)<=90
                theta = -(Result.IncidentSpherical(1)-Result.ReflectedSpherical(1)); % Get theta from the information in Result.
                if abs(theta)<=90    && SF.Intensity > 1e-10                         % If theta in quadran I or IV and the intensity is significant
                    theta=theta*pi/180;                                              % Switch theta into radians, get psi and switch into radians.
                    psi = 90-Result.ReflectedSpherical(2);
                    psi = psi*pi/180;
                    
                    x = Detector.DistanceToSample*tan(theta);                       
                    y = (Detector.DistanceToSample/cos(theta))*tan(psi);
                   
                    x = round(x*10)/10;
                    y = round(y*10)/10;
                    if imag(SF.BraggAngle)==0 && imag(theta)==0 && imag(psi)==0 % If the Bragg angle, theta and psi are 0 (center of the screen)
                        
                        if (strcmpi(Detector.Shape, 'square')==1 && abs(x)<Detector.Size/2 && y<=(Detector.Size/2+Detector.Offset(2)) && y>=(0)) || (strcmpi(Detector.Shape, 'circle')==1 && (x^2+y^2)<(Detector.Size/2)^2)
                            %[h k l]   % Check the shape of the detector
                            pix_r = floor((y/Detector.Size+0.5)*size(I,1)+0.5-Detector.Offset(2)*PixelsPerUnit);
                            pix_c = floor((x/Detector.Size+0.5)*size(I,2)+0.5-Detector.Offset(1)*PixelsPerUnit);
                             
                            
                            %
                            if size(find(xy_space(:,1)==round(x)),1)==0 || size(find(xy_space(:,2)==round(y)),1)==0

                                
                                I = CreateSpot(I, pix_c, pix_r, Detector.SpotFWHMx*PixelsPerUnit, Detector.SpotFWHMy*PixelsPerUnit, sqrt(SF.Intensity), atan(x/y)*180/pi);
                                
                                %Reflects over vertical axis.
                                pix_r = floor((y/Detector.Size+0.5)*size(I,1)+0.5-Detector.Offset(2)*PixelsPerUnit);
                                pix_c = floor((-x/Detector.Size+0.5)*size(I,2)+0.5-Detector.Offset(1)*PixelsPerUnit);                                                           
                                I = CreateSpot(I, pix_c, pix_r, Detector.SpotFWHMx*PixelsPerUnit, Detector.SpotFWHMy*PixelsPerUnit, sqrt(SF.Intensity), -atan(x/y)*180/pi);
                                
                                
                                text(x-Detector.Offset(1),y-Detector.Offset(2),strcat([num2str(h), num2str(k), num2str(l)]));
                                text(-x-Detector.Offset(1),y-Detector.Offset(2),strcat([num2str(h), num2str(k), num2str(l)]));
                                
                                % Collect data for table
                                Table.h=h;
                                Table.k=k;
                                Table.l=l;
                                Table.Incident_Theta=Result.IncidentSpherical(1);
                                Table.Incident_Psi=Result.IncidentSpherical(2);
                                Table.Reflected_Theta=Result.ReflectedSpherical(1);
                                Table.Reflected_Psi=Result.ReflectedSpherical(2);
                                Table.Theta_Difference=Result.ReflectedSpherical(1)-Result.IncidentSpherical(1);
                                if index>1
                                    Table.Angle_to_Next_Theta_I=Result.IncidentSpherical(1)-Old_Theta_I;
                                    Table.Angle_to_Next_Theta_R=Result.ReflectedSpherical(1)-Old_Theta_R;
                                else
                                    Table.Angle_to_Next_Theta_I=0;
                                    Table.Angle_to_Next_Theta_R=0;
                                end
                                Table.Intensity=SF.Intensity;
                                Table.Detector_X=pix_c;
                                Table.Detector_Y=pix_r;
                                Table.IncidentX=Result.Incident(1);
                                Table.IncidentY=Result.Incident(2);
                                Table.IncidentZ=Result.Incident(3);
                                Table.ReflectedX=Result.Reflected(1);
                                Table.ReflectedY=Result.Reflected(2);
                                Table.ReflectedZ=Result.Reflected(3);
                                
                                Array(index)=Table;
                                Old_Theta_I=Result.IncidentSpherical(1);
                                Old_Theta_R=Result.ReflectedSpherical(1);
                                index=index+1;
                                % End of collection of data for table
                            else
                                %    [h k l]
                                % [x y]
                            end
                            xy_space = [xy_space; round(x) round(y)];
                        end
                    end
                end
            end
        end
    end
end


I = flipud(I);


% Save table
Table=struct2table(Array);
time=datestr(datetime('now'));
time(15)='_';
time(18)='_';
time(12)='_';

NameOFile=strcat(Lattice.Symbol,'_',Lattice.Type,'_',num2str(Lattice.Normal(1)),num2str(Lattice.Normal(2)),...
    num2str(Lattice.Normal(3)),'_',time,'_','XRD_spherical_angles.');
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

%
if nargin>4 % plot result
    if strcmpi(Detector.Shape, 'square') == 1
        %plot([-Detector.Size/2 Detector.Size/2], [Detector.Size/2 Detector.Size/2], '-k', 'LineWidth', 2)
        %plot([-Detector.Size/2 Detector.Size/2], [-Detector.Size/2 -Detector.Size/2], '-k', 'LineWidth', 2)
        %plot([-Detector.Size/2 -Detector.Size/2], [-Detector.Size/2 Detector.Size/2], '-k', 'LineWidth', 2)
        %plot([Detector.Size/2 Detector.Size/2], [-Detector.Size/2
        %Detector.Size/2], '-k', 'LineWidth', 2)
    end
    if strcmpi(Detector.Shape, 'circle') == 1
        THETA = linspace(0,2*pi,100);
        RHO = ones(1,100)*(Detector.Size/2);
        [X,Y] = pol2cart(THETA,RHO);
        plot(X,Y,'r-');
    end
    axis([-Detector.Size/2 Detector.Size/2 -Detector.Size/2 Detector.Size/2])
    
    box on
    plot(xlim, [-Detector.Offset(2) -Detector.Offset(2)], ':')
    xlabel('detector x coordinate [mm]')
    ylabel('detector y coordinate [mm]')
    % title(strcat(['sample-detector distance = ', num2str(Detector.DistanceToSample), ' mm, detector size = ', num2str(Detector.Size), ' mm, vertical offset = ', num2str(Detector.Offset(2)), ' mm']))
     title('Labels of diffraction spots')
    subplot(1,2,2)
    hold off
       
    imagesc(I)
    hold on
      %  plot([1 size(I,2)], [-Detector.Offset(2) -Detector.Offset(2)], 'k')
      title('Diffraction pattern')
      set(gca,'xtick',[])
      set(gca,'ytick',[])
end
subplot(1,2,1);
axis('square');
subplot(1,2,2);
axis('square');

end

%% Function: Create Spot for the XRD Pattern
function IMAGE = CreateSpot(IMAGE, CX, CY, WX, WY, AMPLITUDE, ANGLE)

% AMPLITUDE

f = 1.5;

W = max(WY,WX);
cx = f*ceil(W)+1;
cy = f*ceil(W)+1;
TEMP_IMAGE = zeros(2*f*ceil(W)+1, 2*f*ceil(W)+1);
n = size(TEMP_IMAGE,1);
m = size(TEMP_IMAGE,2);

i = repmat((1:m),[n,1]);
j = repmat((1:n)',[1,m]);
TEMP_IMAGE =  AMPLITUDE*exp(-4*log(2)*(j-cy).^2/WY^2 -4*log(2)*(i-cx).^2/WX^2);
TEMP_IMAGE = imrotate(TEMP_IMAGE,ANGLE,'crop');

if CY-f*ceil(W)<1
    TEMP_IMAGE = TEMP_IMAGE(2-CY+f*ceil(W):size(TEMP_IMAGE,1),:);
end
if size(IMAGE,1)<CY+f*ceil(W)
    TEMP_IMAGE = TEMP_IMAGE(1:size(TEMP_IMAGE,1)+size(IMAGE,1)-CY-f*ceil(W),:);
end
if CX-f*ceil(W)<1
    TEMP_IMAGE = TEMP_IMAGE(:,2-CX+f*ceil(W):size(TEMP_IMAGE,2));
end
if size(IMAGE,2)<CX+f*ceil(W)
    TEMP_IMAGE = TEMP_IMAGE(:,1:size(TEMP_IMAGE,2)+size(IMAGE,2)-CX-f*ceil(W));
end

IMAGE(max(1,CY-f*ceil(W)):min(CY+f*ceil(W),size(IMAGE,1)), max(1,CX-f*ceil(W)):min(CX+f*ceil(W),size(IMAGE,2))) = IMAGE(max(1,CY-f*ceil(W)):min(CY+f*ceil(W),size(IMAGE,1)), max(1,CX-f*ceil(W)):min(CX+f*ceil(W),size(IMAGE,2))) + TEMP_IMAGE;

end


