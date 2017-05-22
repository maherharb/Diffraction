function C=GetAtomicColor(Z)

if isnumeric(Z)==0
    error('Atomic number should be an integer between 1 and 92. Type "help GetAtomicMass" to learn more.')
else
    if sum(Z>92) || sum(Z<1) || sum(mod(Z,1))~=0
        error('Atomic number should be an integer between 1 and 92. Type "help GetAtomicMass" to learn more.')
    end
end

C = zeros(size(Z,2),3);
load('AtomicRadii');

for j=1:size(Z,2)
    C(j,1:3) = AR(Z(1,j),3:5);
end
end