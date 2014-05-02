package com.inadram.repo;

import com.inadram.customer.Customer;

import java.util.ArrayList;
import java.util.List;

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
