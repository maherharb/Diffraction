% XRAYSCATTERINGFACTORS Calculate the x-ray scattering factors based on
% relativistic Hartree-fock calculation by P.A. Doyle and P.S. Turner, Acta
% Cryst. A24, 390 (1968); and (optional) Plot the scattering factors vs.
% scattering vector.
%
% XRAYSCATTERINGFACTORS(Z, s, FIGNUM)
%        Z: Atomic number of the element
%        S: The scattering vector in A-1 defined as 2sin(theta)/lambda
%   FIGNUM: (optional) Figure number in which to plot the anomalous scattering factors
%
% Multiple calculations can be made at once by providing an array of atomic
% numbers Z, and an array of scattering vectors S. In that case, the
% function returns a matrix where columns correspond to atomic numbers and
% rows to scattering vectors (see example 1).
%
% If S is a 2 element vector, the calculation is made for 501 points
% within the range specified by S (see example 2).
%
% Example 1 (scattering factors for carbon and oxygen):
%   XrayScatteringFactors([6 8], [0 0.5 1 1.5 2])
%
% Example 2 (plot scattering factors for a bunch of elements):
%   XrayScatteringFactors([6 8 23 32], [0 2], 1)
%
% Last update: 06-03-2011, Maher Harb

function f0 = XrayScatteringFactors(Z, s, FigNum)

if nargin<2
    error('Insufficient number of inputs. You should supply the Scattering vector and the Atomic number. e.g. ScatteringFactor(1.02, 6)');
end

if length(s)==2
    s = linspace(s(1),s(length(s)), 501);
    s = s';
end

if size(s,2)>1
    s=s'; % make sure s is a column
end

s = s/2; % Doyleand Turner define s as sin(theta)/lambda

load XrayRealSF.mat

f0 = ones(size(s,1),size(Z,2));
for j=1:size(Z,2)
    f0(:,j) = f0(:,j)*SF(Z(j),9); % c
    for i=1:4
        f0(:,j) = f0(:,j) + SF(Z(j),i)*exp(-SF(Z(j),i+4)*s.^2);
    end
end

if nargin>2 && length(s)>1 % plot result
    figure(FigNum)
    hold off
    plot(2*s, f0)
    xlabel('Scattering vector (A^-^1)');
    ylabel('f_0')
    for i=1:length(Z)
        [~, ~, ~, l_text] = legend;
        legend(l_text, GetElementSymbol(Z(i)))
    end
end