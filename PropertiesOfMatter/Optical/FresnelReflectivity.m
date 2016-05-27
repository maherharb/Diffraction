function [Rs Rp] = FresnelReflectivity(n, theta) % theta is in rad

rs=(cos(theta)-sqrt(n^2-sin(theta).^2))./(cos(theta)+sqrt(n^2-sin(theta).^2));
rp=(-n^2*cos(theta)+sqrt(n^2-sin(theta).^2))./(n^2*cos(theta)+sqrt(n^2-sin(theta).^2));

Rs = abs(rs).^2;
Rs = Rs'; % column

Rp = abs(rp).^2;
Rp = Rp'; % column
