% PARSECHEMICALSYMBOL Parse a string representing a chemical symbol and
% returns the constituent elements.
%
% [Z N] = PARSECHEMICALSYMBOL(SYMBOL)
%       SYMBOL: (string) Chemical formula of the molecule
%            Z: (integer) An array of the atomic numbers for the elements found in the molecule
%            N: (integer) An array of the numbner of atoms for each element found in the molecule
%
% Note that SYMBOL is case sensitive. For instance, the symbol of silicon
% is Si, whereas SI is considered invalid because it is ambiguous.
%
% Example 1 (methanol):
%   [Z N] = ParseChemicalSymbol('CH3OH')
%
% Exampe 2 (silicon oxide):
%   [Z N] = ParseChemicalSymbol('SiO2')
%
% Last update: 05-03-2011, Maher Harb

function [Z N] = ParseChemicalSymbol(Symbol)


Z = []; % atmic numbers
N = []; % weights

element = Symbol(1);
if (double(element) >=65 && double(element) <=90) % upper case
else
    error([Symbol, ' is an invalid chemical symbol.'])
end

number = '';

for i=2:length(Symbol)
    char = Symbol(i);
    if (double(char) >=97 && double(char) <=122) % lower case
        element = strcat(element, char);
        Z = [Z GetAtomicNumber(element)];
        element = '';
        if i==length(Symbol)
            N = [N 1];
        end
    elseif (double(char) >=65 && double(char) <=90) % upper case
        if length(element)>0
            Z = [Z GetAtomicNumber(element)];
        else
            %            error([Symbol, ' is an invalid chemical symbol.'])
        end
        if length(number)>0
            N = [N str2num(number)];
            number = '';
        else
            N = [N 1];
        end
        element = char;
    elseif (double(char) >=48 && double(char) <=57) % number
        if length(element)>0
            Z = [Z GetAtomicNumber(element)];
            element = '';
        end
        number=strcat(number,char);
    else
        error([Symbol, ' is an invalid chemical symbol.'])
    end
end


if length(element)>0
    Z = [Z GetAtomicNumber(element)];
    N = [N 1];
end
if length(number)>0
    N = [N str2num(number)];
end

end
