class Worker:
    id: int
    dep_id: str
    age: int
    salary: int
    full_name: str

    def __init__(self, id: int, worker_name: str, age: int, salary: int, dep_id: int):
        self.id = id
        self.full_name = worker_name
        self.age = age
        self.salary = salary
        self.dep_id = dep_id

    def __repr__(self) -> str:
        return f'id: {self.id} Full name: {self.full_name} age: {self.age} salary: {self.salary} dep id {self.dep_id}'
