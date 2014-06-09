package com.inadram.repo;

import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Repository;

import com.inadram.customer.Customer;
import org.springframework.stereotype.Service;

public class hibernateRepositoryImplementation implements CustomerRepository {

	@Override
	public List<Customer> findAll() {
		List<Customer> customers = new ArrayList<Customer>();

		Customer customer = new Customer();
		customer.setFirstName("Amir");
		customer.setLastName("Mardani");
		customers.add(customer);
		return customers;
	}
}
