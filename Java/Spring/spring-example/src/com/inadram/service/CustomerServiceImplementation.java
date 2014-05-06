package com.inadram.service;

import com.inadram.customer.Customer;
import com.inadram.repo.CustomerRepository;

import java.util.List;

public class CustomerServiceImplementation implements CustomerService {
	private CustomerRepository customerRepository;

	public void setCustomerRepository(CustomerRepository customerRepository) {
		this.customerRepository = customerRepository;
	}

	@Override
	public List<Customer> findAll() {
		return customerRepository.findAll();
	}

}
