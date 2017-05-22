% Created for electron diffraction in transmission.
% It will generate the diffraction patter for electrons for all planes of
% reflectinos inputed. If a visual representation of the direction of the
% beam is desired, add a 6th input as an integer positive number or use
% TransmissionDiffraction alone for the specified Bragg ange, surface and
% reflection normals.
% The shapes permitted for the detector are only circle and square. Default
% is square.
% Last Updated 5/16/17 Jacob Bolduc

function [I] = GeometricalSimulation2(Lattice, Probe, Detector, hkl_space, FigNum,FigNumElectroRepresentation)

% save GeometricalSimulation1.mat Lattice Probe Crystal Detector hkl_space

I = zeros(1000,1000);
PixelsPerUnit = size(I,1)/Detector.Size;
% dy = Detector.DistanceToSample*tan((Probe.psi)*pi/180);
dy = 0 ;


%Detector Shape check. If no shape was ever given in the main form, the
%variable defaults to square.
if isfield(Detector,'Shape')==0  % default
    Detector.Shape =  'square';
elseif Detector.Shape == 's'
    Detector.Shape =  'square';
elseif Detector.Shape ==  'c'
    Detector.Shape =  'circle';
end

if nargin>4 % plot result
    figure(FigNum)
    subplot(1,2,1)
    %  hold off
    plot(0-Detector.Offset(1), -dy-Detector.Offset(2), 'o', 'LineWidth', 2)
    hold on
end

xy_space = [0 0];
log = [];

index=1;
Bragg=zeros(1,125); %What are you doing here, Cosine?
for k = hkl_space
    for h = hkl_space        
        for l = hkl_space
            if h==0 && k==0 && l==0
            else
                Lattice.Reflection = [h k l]; % Lattice Reflection is defined
                [SF, Lattice, Probe] = StructureFactor(Lattice, Probe); %Struct Factor is called
                Bragg(index)=SF.BraggAngle; 
                index=index+1;
                
                
                if SF.BraggAngle< 2 %this is for electrons, so we assume small Bragg angles
                    
                    
                    % Get results from TransmissionsDiffraction
                    if nargin>5
                        Result =TransmissionDiffraction(SF.BraggAngle, SF.CrystalNormal, SF.ReflectionNormal,FigNumElectroRepresentation); %% && Result.ReflectedSpherical(2)<=90
                    else
                        Result =TransmissionDiffraction(SF.BraggAngle, SF.CrystalNormal, SF.ReflectionNormal);
                    end
                    
                    theta = Result.ReflectedSpherical(1);
                    % Intensity minimum threshold of 1e-10 
                    if SF.Intensity > 1e-10
                        theta=theta*pi/180;
                        psi = 180-Result.ReflectedSpherical(2);
                        psi = psi*pi/180;
                        x = Detector.DistanceToSample*tan(psi)*cos(theta);
                        y = Detector.DistanceToSample*tan(psi)*sin(theta);
                        x = round(x*10)/10;
                        y = round(y*10)/10;

                     % if imag(SF.BraggAngle)==0 && imag(theta)==0 && imag(psi)==0
                       log = [log; h, k, l];
                            %Checks to makes sure the spot is:
                            % a) Real 
                            % b) On the Detector screen
                            if (strcmpi(Detector.Shape, 'square')==1 && abs(x)<Detector.Size/2 && abs(y)<Detector.Size/2+Detector.Offset(2)) || (strcmpi(Detector.Shape, 'circle')==1 && (x^2+y^2)<(Detector.Size/2)^2)
                                
                                pix_r = floor((y/Detector.Size+0.5)*size(I,1)+0.5);
                                pix_c = floor((x/Detector.Size+0.5)*size(I,2)+0.5);
                                
                                % if size(find(xy_space(:,1)==round(x)),1)==0 && size(find(xy_space(:,2)==round(y)),1)==0
                                I = CreateSpot(I, pix_c-Detector.Offset(1)*PixelsPerUnit, pix_r-Detector.Offset(2)*PixelsPerUnit, Detector.SpotFWHMx*PixelsPerUnit, Detector.SpotFWHMy*PixelsPerUnit, sqrt(SF.Intensity), atan(x/y)*180/pi);
                                
                                %Reflects the diffraction pattern over the
                                %vertical axis; noice the "-x" in pix_c
                                %here.
                                pix_r = floor((y/Detector.Size+0.5)*size(I,1)+0.5);
                                pix_c = floor((-x/Detector.Size+0.5)*size(I,2)+0.5);
                                if nargin>5
                                    figure(FigNum)
                                end
                                display(strcat(num2str(h),num2str(k),num2str(l)))
                                
                                I = CreateSpot(I, pix_c-Detector.Offset(1)*PixelsPerUnit, pix_r-Detector.Offset(2)*PixelsPerUnit, Detector.SpotFWHMx*PixelsPerUnit, Detector.SpotFWHMy*PixelsPerUnit, sqrt(SF.Intensity), -atan(x/y)*180/pi);
                                
                                text(x-Detector.Offset(1),y-Detector.Offset(2),strcat([num2str(h), num2str(k), num2str(l)]));
                                text(-x-Detector.Offset(1),y-Detector.Offset(2),strcat([num2str(h), num2str(k), num2str(l)]));
                                %    else
                                %        % [x y]
                                %    end
                                xy_space = [xy_space; round(x) round(y)];
                             end
%                         end
                    end
                end
            end
        end
    end
end
I = flipud(I);
% fprintf('hkl values');
% log;
  
  
if nargin>4 % plot result
    figure(FigNum)
    if strcmpi(Detector.Shape, 'square') == 1
        plot([-Detector.Size/2 Detector.Size/2], [Detector.Size/2 Detector.Size/2], '-b', 'LineWidth', 1)
        plot([-Detector.Size/2 Detector.Size/2], [-Detector.Size/2 -Detector.Size/2], '-b', 'LineWidth', 1)
        plot([-Detector.Size/2 -Detector.Size/2], [-Detector.Size/2 Detector.Size/2], '-b', 'LineWidth', 1)
        plot([Detector.Size/2 Detector.Size/2], [-Detector.Size/2
        Detector.Size/2], '-b', 'LineWidth', 1)
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
    xlabel('x [mm]')
    ylabel('y [mm]')
    title(strcat(['sample-detector distance = ', num2str(Detector.DistanceToSample), ' mm, detector size = ', num2str(Detector.Size), ' mm, vertical offset = ', num2str(Detector.Offset(2)), ' mm']))
    subplot(1,2,2)
    hold off
    
    imagesc(I)
end
subplot(1,2,1);
axis('square');
subplot(1,2,2);
axis('square');

end


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


