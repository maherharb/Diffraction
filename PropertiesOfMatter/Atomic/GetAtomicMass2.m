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
[~,columns]=size(Z);

if isnumeric(Z(i))==0
    error('Atomic number should be an integer between 1 and 92. Type "help GetAtomicMass" to learn more.')
else
    if sum(Z(i)>92) || sum(Z(i)<1) || sum(mod(Z(i),1))~=0
        error('Atomic number should be an integer between 1 and 92. Type "help GetAtomicMass" to learn more.')
    end
end

W = zeros(size(Z(i)));
load('AtomicWeights');

for j=1:size(Z(i),2)
    W(1,j) = AW(Z(1,j),2);
end
end

