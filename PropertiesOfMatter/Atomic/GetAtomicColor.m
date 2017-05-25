% GETATOMICCOLOR returns a matrix of three numbers between 0 and 1 that
% make up the color code for the specific element according to one of the
% packages in CrystalMaker. 
% GETATOMICCOLOR([6 12 19]) will return [0.0628, 0.0235 0; 1, 0.7843,
% 0.0157; 0.4549, 0, 1];
% This allows you to have the colors for multiple elements at your
% disposal at once. Use PARSECHEMICALSYMBOL in order to get the Z from the
% symbols in your Lattice.Symbol.
%
% The input can go as high as element 95 but the radii and weight are
% restricted to 92, meaning you would have to add them in AtomicWeights and
% AtomicRadii.mat files and change the checks in the respective GetAtomic
% functions. If you need a different color code do the following:
% load AtomicRadii.mat;
% open the AR matrix and change the colors for the elements you need;
% save('AtomicRadii.mat','AR');
% Same goes for radii.
%
% The color database was taken from the commercial software CrystalMaker 
% CrystalMaker®: a crystal and molecular structures program for Mac and Windows. CrystalMaker Software Ltd, Oxford, England (www.crystalmaker.com)"
%
% Last update - 5-25-2017 Cosmin Popescu

function C=GetAtomicColor(Z)
if isnumeric(Z)==0
    error('Atomic number should be an integer between 1 and 92. Type "help GetAtomicColor" to learn more.')
else
    if sum(Z>95) || sum(Z<1) || sum(mod(Z,1))~=0
        error('Atomic number should be an integer between 1 and 92. Type "help GetAtomicColor" to learn more.')
    end
end

C = zeros(size(Z,2),3);
load('AtomicRadii');

for j=1:size(Z,2)
    C(j,1:3) = AR(Z(1,j),3:5);
end
end