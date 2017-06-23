% Transforms Miller form direction [UVW] into hexagonal Miller-Bravais form
% direction [uvtw]. Example: TRANSFORMMILLER2BRAVAIS([1 0 0; 0 1 2; 3 2 1]);
function [MillerBravaisDirrection]=TransformMiller2Bravais(MillerDirrection)

U=MillerDirrection(:,1);
V=MillerDirrection(:,2);
W=MillerDirrection(:,3);
u=1/3*(2*U-V);
v=1/3*(2*V-U);
t=-(u+v);
w=W;
MillerBravaisDirrection=[u,v,t,w]; 

for i=1:size(MillerBravaisDirrection,1)
    AbsValues=abs(MillerBravaisDirrection(i,:));
    NonZeroValues=AbsValues(find(AbsValues>0));
    Minimum=min(NonZeroValues);
    MillerBravaisDirrection(i,:)=MillerBravaisDirrection(i,:)/Minimum;
end

end