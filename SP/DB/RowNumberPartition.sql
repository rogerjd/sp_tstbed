select *
from Employees

select *
from EmpJobInfoes

select e.Id, eji.ID, *
from Employees e
left join EmpJobInfoes eji on e.Id = eji.Id
order by e.Id

select e.Id, eji.ID, *,
  ROW_NUMBER()  OVER(PARTITION BY e.State order by e.Id)
from Employees e
left join EmpJobInfoes eji on e.Id = eji.Id
--order by e.Address

select state, min(ID)
from Employees
--where State = 'MA'
group by State
--having State = 'MA'
