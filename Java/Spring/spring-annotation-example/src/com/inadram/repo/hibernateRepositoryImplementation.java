package com.inadram.repo;

import com.inadram.customer.Customer;
import java.util.ArrayList;
import java.util.List;

import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Repository;


@Repository("customerRepository")
public class hibernateRepositoryImplementation implements CustomerRepository {

	@Value("${someValue}")
	private String someValue;

	@Override
	public List<Customer> findAll() {
		List<Customer> customers = new ArrayList<Customer>();

		Customer customer = new Customer();
//		customer.setFirstName("Amir");
		customer.setFirstName(someValue);
		customer.setLastName("Mardani");
		customers.add(customer);
		return customers;
	}
}
