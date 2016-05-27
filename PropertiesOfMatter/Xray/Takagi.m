

function out1 = Takagi(A, X, flag, k, g, y)
out1 = [k*(X(1)^2-X(2)^2+1)+2*X(2)*(X(1)-y)-2*g*X(1); -(X(1)^2-X(2)^2+1)+2*X(1)*(X(2)*k+y)-2*g*X(2)]; 


