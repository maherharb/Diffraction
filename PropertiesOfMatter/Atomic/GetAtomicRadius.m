function R = GetAtomicRadius(Z)

if isnumeric(Z)==0
    error('Atomic number should be an integer between 1 and 92. Type "help GetAtomicMass" to learn more.')
else
    if sum(Z>92) || sum(Z<1) || sum(mod(Z,1))~=0
        error('Atomic number should be an integer between 1 and 92. Type "help GetAtomicMass" to learn more.')
    end
end

R = zeros(size(Z));
load('AtomicRadii');

for j=1:size(Z,2)
    R(1,j) = AR(Z(1,j),2);
end
end