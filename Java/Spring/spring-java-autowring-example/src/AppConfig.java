import com.inadram.repo.CustomerRepository;
import com.inadram.repo.hibernateRepositoryImplementation;
import com.inadram.service.CustomerService;
import com.inadram.service.CustomerServiceImplementation;
import org.springframework.context.annotation.*;
import org.springframework.context.support.PropertySourcesPlaceholderConfigurer;

@Configuration
@ComponentScan({"com.inadram"})
@PropertySource("app.someProperty")
public class AppConfig {

	@Bean
	public static PropertySourcesPlaceholderConfigurer getPropertySourcesPlaceholderConfigurer() {
		return new PropertySourcesPlaceholderConfigurer();
	}
	@Bean(name = "customerService")
//	@Scope("singleton")
	@Scope("prototype")
	public CustomerService getCustomerService() {
		return new CustomerServiceImplementation();
	}

	@Bean(name = "customerRepository")
	public CustomerRepository getCustomerRepository() {
		return new hibernateRepositoryImplementation();
	}
}
