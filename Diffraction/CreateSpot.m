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


