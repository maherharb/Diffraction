% Relativistic Hartree-fock X-ray and electron scattering Factors, P.A.
% Doyle and P.S. Turner, Acta Cryst. (1968). A24, 390

function f = XrayScatteringFactor(s, Z, Energy)


[f1 f2] = XrayComplexScatteringFactor(Z, Energy);
f0 = ScatteringFactor(s, Z, 'xrays');

f = repmat(f0, [length(Energy) 1]) + f1 + 1i*f2 - repmat(Z, [length(Energy) 1]);

end