function [r0,r1,r_1] = controller(K,den,roots,r1d)
% funkcia pre vypocet parametrov PID fegulatora metodou rozlozenia polov
% pre system prveho radu v tvare K/Ts+1
% funkcia vracia koeficienty v zlozkovom tvare 
if nargin == 3
    r1 = 0.1;
else
    r1 = r1d;
end 
coeffs = poly(roots);
r0 = (coeffs(2)*(K*r1 + den(1)) - den(2))/K;
r_1 = (coeffs(3)*(K*r1 + den(1)))/K;
end