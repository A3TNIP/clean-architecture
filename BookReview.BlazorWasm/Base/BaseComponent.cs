using System.Collections;
using System.Net.Http.Json;
using CleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Components;

namespace BookReview.BlazorWasm.Base;

public class BaseComponent<T>: ComponentBase
{
    [Inject] private BaseService _service { get; set; }

    protected override Task OnInitializedAsync()
    {
        return base.OnInitializedAsync();
    }

    protected List<Employee> GetAll()
    {
        return _service.GetAllItems();
    }
}