import com.inadram.repo.CustomerRepository;
import com.inadram.repo.hibernateRepositoryImplementation;
import com.inadram.service.CustomerService;
import com.inadram.service.CustomerServiceImplementation;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class AppConfig {

	@Bean(name="customerService")
	public CustomerService getCustomerService(){
		CustomerServiceImplementation customerServiceImplementation= new CustomerServiceImplementation();
		customerServiceImplementation.setCustomerRepository(getCustomerRepository());

		return customerServiceImplementation;
	}

	@Bean(name="customerRepository")
	public CustomerRepository getCustomerRepository(){
		return  new hibernateRepositoryImplementation();
	}
}
