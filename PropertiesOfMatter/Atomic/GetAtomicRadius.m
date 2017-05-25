% Data for radii take from www.ptable.com/#Property/Radius/Calculated and
% www.ptable.com/#Property/Radius/Empirical for the cases where no
% calculated version was available. 
% Dayah, M. (1997, October 1). Dynamic Periodic Table. 
% Retrieved May 25, 2017, from Ptable: 
%
% Last update 5-25-2017 Cosmin Popescu

function R = GetAtomicRadius(Z)

if isnumeric(Z)==0
    error('Atomic number should be an integer between 1 and 92. Type "help GetAtomicMass","help GetAtomicRadius"  or "help GetAtomicColor" to learn more.')
else
    if sum(Z>92) || sum(Z<1) || sum(mod(Z,1))~=0
        error('Atomic number should be an integer between 1 and 92. Type "help GetAtomicMass", "help GetAtomicColor" or "help GetAtomicRadius"  to learn more.')
    end
end

R = zeros(size(Z));
load('AtomicRadii');

for j=1:size(Z,2)
    R(1,j) = AR(Z(1,j),2);
end
end