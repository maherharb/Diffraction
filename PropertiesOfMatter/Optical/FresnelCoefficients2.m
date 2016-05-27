function [rs rp] = FresnelCoefficients2(n_in, n_out, theta_in, theta_out) % theta is in rad

n = n_out/n_in;

rs = (cos(theta_in)-n*cos(theta_out))./(cos(theta_in)+n*cos(theta_out));
rp = (-n*cos(theta_in)+cos(theta_out))./(n*cos(theta_in)+cos(theta_out));
