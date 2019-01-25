# 162ms, 12.41%, 5m, 1t
select * from cinema where description <> 'boring' and ((id mod 2) = 1) order by rating desc