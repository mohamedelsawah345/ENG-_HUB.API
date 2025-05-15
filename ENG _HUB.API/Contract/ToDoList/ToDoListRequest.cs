namespace ENG__HUB.API.Contract.ToDoList
{
    public record ToDoListRequest
    (string Text,
    DateTime CreationDate,
    DateTime? DeadLineDate);
    

}
