% Transforms [uvtw] Miller-Braais form direction for hexagonal lattices in
% [UVW] form for use in normal Miller coordinates 
% Example: TRANSFORMBRAVAIS2MILLER([2,-1,-1,0;-1,2,-1,6;4,1,-5,3]);
function [MillerDirrection]=TransformBravais2Miller(MillerBravaisDirrection)

u=MillerBravaisDirrection(:,1);
v=MillerBravaisDirrection(:,2);
t=MillerBravaisDirrection(:,3);
w=MillerBravaisDirrection(:,4);

U=2*u+v;
V=u+2*v;
W=w;
MillerDirrection=[U,V,W];

for i=1:size(MillerDirrection,1)
    AbsValues=abs(MillerDirrection(i,:));
    NonZeroValues=AbsValues(find(AbsValues>0));
    Minimum=min(NonZeroValues);
    MillerDirrection(i,:)=MillerDirrection(i,:)/Minimum;
end


end