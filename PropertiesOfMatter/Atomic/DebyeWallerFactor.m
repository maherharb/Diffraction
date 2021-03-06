% DEBYEWALLERFACTOR Find the debye-waller factor (B) of the element based
% on parametrization by Gao & Peng. The factor can then be used to
% estimate the reduction in diffracted intensity according to
% I=I(0)exp[-Bs^2/2], where scattering vector s = 2sin(theta)/lambda.
%
% DEBYEWALLERFACTOR(Z, T)
%   Z: (integer) Atomic number of the element
%   T: (decimal) Temperature in Kelvin. 
%
% Example 1 (single value):
%   DebyeWallerFactor(6, 300)
%
% Example 2 (many values):
%   DebyeWallerFactor(14, [300:100:1000])
%
% Last update: 05-03-2011, Maher Harb

function B = DebyeWallerFactor(Z, T)

Z = Z(1);

if isnumeric(Z)==0
    error('Atomic number should be an integer between 1 and 92. Type "help GetElementSymbol" to learn more.')
else
    if Z>92 || Z<1 || mod(Z,1)~=0
        error('Atomic number should be an integer between 1 and 92. Type "help GetElementSymbol" to learn more.')
    end
end

a = zeros(90,5) ; % elements
a(6,:)  = [0.12034 -0.2231e-4  0.3348e-6  -0.2108e-9  0.5320e-13]; % C
a(14,:) = [0.14236  0.9261e-3  0.1623e-5  -0.1677e-8  0.6351e-12]; % Si
a(32,:) = [0.06984  0.1650e-2  0.9448e-6  -0.1010e-8  0.3904e-12]; % Ge
a(79,:) = [0.02981  0.1930e-2  0.4444e-6  -0.4842e-9  0.1895e-12]; % Au
a(83,:) = [0.03610  0.3580e-2  0.1111e-5  -0.1855e-8  0.1140e-11]; % Bi

if sum(a(Z,:))==0
    warning('Debye-Waller parametrization data not avialble for the requested element.')
end

B = zeros(1,length(T)) ; 
for i=0:4
    B = B + a(Z,i+1)*T.^i ;
end

