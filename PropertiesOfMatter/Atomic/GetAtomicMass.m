% GETATOMICMASS find the atomic mass of an element based on its atomic
% number.
%
% GETATOMICMASS(Z)
%   Z: (integer) Atomic number of the element
%
% Note: This function fetches the atomic masses from data file
% AtomicWeights.mat
%
% Example:
%   GetAtomicMass(14)
%
% Last update: 05-03-2011, Maher Harb

function W = GetAtomicMass(Z)

if isnumeric(Z)==0
    error('Atomic number should be an integer between 1 and 92. Type "help GetAtomicMass" to learn more.')
else
    if Z>92 || Z<1 || mod(Z,1)~=0
        error('Atomic number should be an integer between 1 and 92. Type "help GetAtomicMass" to learn more.')
    end
end

W = zeros(size(Z));
load('AtomicWeights');

for i=1:size(Z,2)
    W(1,i) = AW(Z(1,i),2);
end

end
