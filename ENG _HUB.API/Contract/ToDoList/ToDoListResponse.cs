namespace ENG__HUB.API.Contract.ToDoList
{
    public record ToDoListResponse
     (string Text,
    DateTime CreationDate,
    DateTime? DeadLineDate);
}
