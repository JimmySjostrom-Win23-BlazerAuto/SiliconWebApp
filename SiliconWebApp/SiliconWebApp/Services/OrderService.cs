using SiliconWebApp.Factories;
using SiliconWebApp.Entities;
using SiliconWebApp.Repositories;
using SiliconWebApp.Models;

namespace SiliconWebApp.Services;

public class OrderService(OrderRepository orderRepository)
{
    private readonly OrderRepository _orderRepository = orderRepository;

    // Create 
    public async Task<ResponseResult> CreateOrderAsync(OrderEntity order)
    {
        try
        {
            var result = await _orderRepository.CreateOneAsync(order);
            return result;
        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }

    // Read
    public async Task<ResponseResult> GetAllOrdersAsync()
    {
        try
        {
            var result = await _orderRepository.GetAllAsync();
            return result;
        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }

    // Read by Id
    public async Task<ResponseResult> GetOrderByIdAsync(int orderId)
    {
        try
        {
            var result = await _orderRepository.GetOneAsync(order => order.Id == orderId);
            return result;
        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }

    // Update
    public async Task<ResponseResult> UpdateOrderAsync(int orderId, OrderEntity updatedOrder)
    {
        try
        {
            var result = await _orderRepository.UpdateOneAsync(order => order.Id == orderId, updatedOrder);
            return result;
        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }

    // Delete 
    public async Task<ResponseResult> DeleteOrderAsync(int orderId)
    {
        try
        {
            var result = await _orderRepository.DeleteOneAsync(order => order.Id == orderId);
            return result;
        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }
}