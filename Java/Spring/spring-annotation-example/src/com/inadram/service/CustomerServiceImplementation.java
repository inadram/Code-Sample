package com.inadram.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.inadram.customer.Customer;
import com.inadram.repo.CustomerRepository;

@Service("customerService")
public class CustomerServiceImplementation implements CustomerService {

	private CustomerRepository customerRepository;

	@Autowired
	public CustomerServiceImplementation(CustomerRepository customerRepository){
		this.customerRepository= customerRepository;
		System.out.println("constructor injection");
	}

//	@Autowired
//	public void setCustomerRepository(CustomerRepository customerRepository){
//		this.customerRepository = customerRepository;
//		System.out.println("setter injection");
//	}

	@Override
	public List<Customer> findAll() {
		return customerRepository.findAll();
	}

}
