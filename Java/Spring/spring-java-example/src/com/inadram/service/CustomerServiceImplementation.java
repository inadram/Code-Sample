package com.inadram.service;

import java.util.List;

import com.inadram.repo.hibernateRepositoryImplementation;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.inadram.customer.Customer;
import com.inadram.repo.CustomerRepository;

public class CustomerServiceImplementation implements CustomerService {

	public void setCustomerRepository(CustomerRepository customerRepository) {
		this.customerRepository = customerRepository;
	}

	private CustomerRepository customerRepository ;

	@Override
	public List<Customer> findAll() {
		return customerRepository.findAll();
	}

}
