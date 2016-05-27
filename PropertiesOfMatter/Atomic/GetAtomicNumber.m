% GETATOMICNUMBER find the atomic number of an element based on its symbol.
%
% GETATOMICNUMBER(SYMBOL)
%       SYMBOL: (string) The symbol of the element
%
% Example:
%   GetAtomicNumber('Si')
%
% Last update: 05-03-2011, Maher Harb

function Z = GetAtomicNumber(Symbol)

if ischar(Symbol)==0
    error('Symbol should be a string. Type "help GetAtomicNumber" to learn more.')
end


s = {'H', 'He', ...
    'Li', 'Be', 'B', 'C', 'N', 'O', 'F', 'Ne',...
    'Na', 'Mg', 'Al', 'Si', 'P', 'S', 'Cl', 'Ar',...
    'K', 'Ca', 'Sc', 'Ti', 'V', 'Cr', 'Mn', 'Fe', 'Co', 'Ni', 'Cu', 'Zn', 'Ga', 'Ge', 'As', 'Se', 'Br', 'Kr',...
    'Rb', 'Sr', 'Y', 'Zr', 'Nb', 'Mo', 'Tc', 'Ru', 'Rh', 'Pd', 'Ag', 'Cd', 'In', 'Sn', 'Sb', 'Te', 'I', 'Xe',...
    'Cs', 'Ba', 'La', 'Hf', 'Ta', 'W', 'Re', 'Os', 'Ir', 'Pt', 'Au', 'Hg', 'Tl', 'Pb', 'Bi', 'Po', 'At', 'Rn',...
    'Fr', 'Ra', 'Ac',...
    'Ce', 'Pr', 'Nd', 'Pm', 'Sm', 'Eu', 'Gd', 'Tb', 'Dy', 'Ho', 'Er', 'Tm', 'Yb', 'Lu',...
    'Th', 'Pa', 'U'};

z = {1, 2, ...
    3, 4, 5, 6, 7, 8, 9, 10,...
    11, 12, 13, 14, 15, 16, 17, 18,...
    19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34 ,35, 36,...
    37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54,...
    55, 56, 57, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86,...
    87, 88, 89,...
    58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71,...
    90, 91, 92};

j=0;
for i=1:92
    if strcmp(s(i),Symbol)==1
        j=i;
        break
    end
end

%ElementsMap = containers.Map(s, z);

%Z = ElementsMap(Symbol);
if j>0
    Z = z(j);
    Z = Z{1};
else
    Z = 0;
    error([Symbol, ' is an invalid element.'])
end

end
